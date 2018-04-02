using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SharpEditor
{
    public partial class frmSharpEditor : Form
    {
        public FontDialog fd = new FontDialog();
        public OpenFileDialog openfileDialog;
        TabPage tp;
        System.Timers.Timer theTimer;
        private static ConcurrentBag<string> dictionary;
        Task dictionaryTask;
        List<Task> closeTasks = new List<Task>();

        public frmSharpEditor()
        {
            InitializeComponent();

            //Focus on rich text box
            rtbMain.TabIndex = 5;
            rtbMain.Select();

            //set current tab page value
            tp = tcMain.SelectedTab;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (getRichTextBox(tp).SelectionFont.Bold){
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, ~FontStyle.Bold & getRichTextBox(tp).SelectionFont.Style);
            }else {
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, FontStyle.Bold | getRichTextBox(tp).SelectionFont.Style);
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getRichTextBox(tp).SelectionFont.Italic){
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, ~FontStyle.Italic & getRichTextBox(tp).SelectionFont.Style);
            }else{
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, FontStyle.Italic| getRichTextBox(tp).SelectionFont.Style);
            }
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getRichTextBox(tp).SelectionFont.Underline){
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, ~FontStyle.Underline & getRichTextBox(tp).SelectionFont.Style);
            }else{
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, FontStyle.Underline | getRichTextBox(tp).SelectionFont.Style);
            }
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getRichTextBox(tp).SelectionFont.Strikeout){
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, ~FontStyle.Strikeout & getRichTextBox(tp).SelectionFont.Style);
            }else{
                getRichTextBox(tp).SelectionFont = new Font(fd.Font, FontStyle.Strikeout | getRichTextBox(tp).SelectionFont.Style);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            if (fd.ShowDialog() == DialogResult.OK){
                getRichTextBox(tp).SelectionFont = fd.Font;
            }
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getRichTextBox(tp).WordWrap){
                getRichTextBox(tp).WordWrap = false;
            }else {
                getRichTextBox(tp).WordWrap = true;
            }
        }

        private void frmSharpEditor_Load(object sender, EventArgs e)
        {
            //populate dictionary values
            dictionaryTask = Task.Factory.StartNew(populateDictionary);
            //set FontDialog default values
            fd.Font = new Font("Segoe UI",12);
            //start timer for auto save
            theTimer = new System.Timers.Timer(10000);
            theTimer.Elapsed += autoSave;
            theTimer.Start();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getRichTextBox(tp).Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getRichTextBox(tp).Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getRichTextBox(tp).Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new tasks for creating a new file
            Task newFileTask = new Task(newFile);
            newFileTask.Start();
        }

        public RichTextBox createRichTextBox() {
            RichTextBox rtbMain = new RichTextBox(); //creates a new richtext box object
            rtbMain.BorderStyle = BorderStyle.None; //sets border style to rich text box
            rtbMain.Font = fd.Font; // sets font for rich text box
            rtbMain.WordWrap = false; // sets word wrap false for rich text box
            rtbMain.Dock = DockStyle.Fill; //docks rich text box 
            // sets event handlers for the rich text box
            rtbMain.TextChanged += new System.EventHandler(this.rtbMain_TextChanged);
            rtbMain.SelectionChanged += new System.EventHandler(this.rtbMain_SelectionChanged);
            rtbMain.KeyDown += new KeyEventHandler(this.rtbMain_KeyDown);
            rtbMain.Focus(); // sets focus for rich text box
            return rtbMain;
        }

        public void newFile() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => newFile()));
            }else{
                TabPage tp = new TabPage("New"); //creates a new tab page
                RichTextBox rtbMain = createRichTextBox();//creates a rich text box
                tp.Controls.Add(rtbMain); // adds rich text box to the tab page
                tcMain.TabPages.Add(tp);// adds tab page to tab control
                tcMain.SelectedTab = tp;// focus on the new tab that was created
            }
        }

        public RichTextBox getRichTextBox(TabPage tp) {
            RichTextBox rtb=null; // declare a rich text box
            rtb = tp.Controls[0] as RichTextBox; // assign current tab's rich text box
            return rtb; // return rich text box
        }

        public void openFile() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => openFile()));
            }else{
                openfileDialog = new OpenFileDialog();
                Stream myStream = null;
                if (openfileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                    if ((myStream = openfileDialog.OpenFile()) != null){
                        bool flag = false;
                        string filename = openfileDialog.FileName;//copies the path of the file into a variable
                        TabControl.TabPageCollection tabs = tcMain.TabPages;
                        try{                            
                            Parallel.ForEach(Partitioner.Create(0, tabs.Count), (range, loopState) =>{
                                for (int i = range.Item1; i < range.Item2; i++){
                                    if (tabs[i].Tag!=null) {
                                        if (tabs[i].Tag.Equals(filename)){
                                            tcMain.BeginInvoke((MethodInvoker)delegate { tcMain.SelectedTab = tabs[i];});                               
                                            flag = true;
                                            break;
                                        }
                                    }                                  
                                }
                                if (flag) {
                                    loopState.Break();
                                }
                                
                            });
                        }
                        catch (AggregateException ae){
                            foreach (Exception innerEx in ae.InnerExceptions) { }
                        }
                        if (!flag) {
                            string readfiletext = File.ReadAllText(filename);//reads all the text from the opened file
                            string[] filepath = filename.Split('\\');
                            string tabTitle = filepath[filepath.Length - 1];

                            RichTextBox rtbMain = createRichTextBox();
                            rtbMain.Text = readfiletext;
                            rtbMain.SelectionStart = rtbMain.Text.Length;

                            TabPage tp = new TabPage(tabTitle); //creates a new tab page
                            tp.Controls.Add(rtbMain); // adds rich text box to the tab page
                            tcMain.TabPages.Add(tp);
                            tcMain.SelectedTab = tp;
                            tp.Tag = filename;
                            spellCheck();
                        }
                    }
                    myStream.Close();
                }
                
            }
        }

        public void saveAs(TabPage tp) {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => saveAs(tp)));
            }else{
                SaveFileDialog savefileDialog = new SaveFileDialog();
                savefileDialog.Filter = "*.txt(textfile)|*.txt";
                savefileDialog.FileName = "*.txt";
                if (savefileDialog.ShowDialog() == DialogResult.OK){
                    getRichTextBox(tp).SaveFile(savefileDialog.FileName, RichTextBoxStreamType.PlainText);
                    getRichTextBox(tp).Focus();
                    string[] filepath = savefileDialog.FileName.Split('\\');
                    string tabTitle = filepath[filepath.Length - 1];
                    tp.Text = tabTitle;
                    tp.Tag = savefileDialog.FileName;
                }
            }
        }

        public void saveFile(TabPage tp) {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => saveFile(tp)));
            }else{
                SaveFileDialog savefileDialog = new SaveFileDialog();
                savefileDialog.Filter = "*.txt(textfile)|*.txt";
                if (tp.Tag == null){
                    savefileDialog.FileName = "*.txt";
                    if (savefileDialog.ShowDialog() == DialogResult.OK){
                        getRichTextBox(tp).SaveFile(savefileDialog.FileName, RichTextBoxStreamType.PlainText);
                        getRichTextBox(tp).Focus();
                        string[] filepath = savefileDialog.FileName.Split('\\');
                        string tabTitle = filepath[filepath.Length - 1];
                        tp.Text = tabTitle;
                        tp.Tag = savefileDialog.FileName;
                    }
                }else{
                    getRichTextBox(tp).SaveFile((string)tp.Tag, RichTextBoxStreamType.PlainText);
                }
            }
        }

        public void saveAll(){       
            TabControl.TabPageCollection tabs = tcMain.TabPages;
            try{
                Parallel.ForEach(Partitioner.Create(0, tabs.Count), (range) =>{
                    for (int i = range.Item1; i < range.Item2; i++){
                        saveFile(tabs[i]);
                    }
                });
            }catch (AggregateException ae) {
                foreach (Exception innerEx in ae.InnerExceptions){}
            }
        }

        public void autoSave(object source, ElapsedEventArgs e)
        {
            if (this.InvokeRequired) {
                this.Invoke(new MethodInvoker(() => autoSave(source,e)));
            }else{
                TabControl.TabPageCollection tabs = tcMain.TabPages;
                try{
                    Parallel.ForEach(Partitioner.Create(0, tabs.Count), (range) =>{
                        for (int i = range.Item1; i < range.Item2; i++){
                            TabPage tp = tabs[i];
                            if (tp.Tag != null){
                                getRichTextBox(tp).BeginInvoke((MethodInvoker)delegate { getRichTextBox(tp).SaveFile((string)tp.Tag, RichTextBoxStreamType.PlainText); });
                            }
                        }
                    });
                }catch (AggregateException ae) {
                    foreach (Exception innerEx in ae.InnerExceptions){}
                }
            }
        }

        public void spellCheck() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => spellCheck()));
            }else{
                List<string> words = getRichTextBox(tp).Text.Split().ToList();
                int startIndex = 0;
                foreach (string word in words){
                    int cursorPosition = getRichTextBox(tp).SelectionStart;
                    int index = getRichTextBox(tp).Text.IndexOf(word, startIndex);
                    getRichTextBox(tp).Select(index, word.Length);
                    System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("^[a-zA-Z]*$");
                    if (dictionary.Contains(word)|| !regEx.IsMatch(word) || (word.Length==1)){               
                        getRichTextBox(tp).SelectionColor = Color.Black;
                    }else {
                        getRichTextBox(tp).SelectionColor = Color.Red;
                    }
                    getRichTextBox(tp).SelectionStart = cursorPosition;
                    startIndex = index+word.Length;                   
                }
            }           
        }


        public void populateDictionary() {
            dictionary = new ConcurrentBag<string>();
            string resource_data = Properties.Resources.dictionary;
            List<string> words = resource_data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string word in words) {
                dictionary.Add(word);
            }
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            //Create task and call openFile method in it
            Task openFileTask = Task.Factory.StartNew(openFile);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create task and call openFile method in it
            Task openFileTask = Task.Factory.StartNew(openFile);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            // create a task and start the saveFile method in it
            Task saveFileTask = Task.Factory.StartNew(()=> saveFile(tp));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the saveFile method in it
            Task saveFileTask = Task.Factory.StartNew(() => saveFile(tp));
        }

        private void rtbMain_TextChanged(object sender, EventArgs e)
        {
            var t1 = Task.Factory.StartNew(calculateLength);
            var t2 = Task.Factory.StartNew(calculateWordCount);
            var t3 = Task.Factory.StartNew(calculateLineNumber);
        }

        public void calculateLength() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => calculateLength()));
            }else {
                tsslLV.Text = getRichTextBox(tp).Text.Length.ToString();
            }   
        }

        public void calculateWordCount() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => calculateWordCount()));
            }else{
                MatchCollection wordColl = Regex.Matches(getRichTextBox(tp).Text, @"[\W]+");
                int count = wordColl.Count;
                tsslWCV.Text = count.ToString();
            }         
        }

        public void calculateLineNumber() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => calculateLineNumber()));
            }else{
                int index = getRichTextBox(tp).SelectionStart;
                int lineNumber = getRichTextBox(tp).GetLineFromCharIndex(index) + 1;
                tsslLnV.Text = lineNumber.ToString();
            }         
        }

        private void rtbMain_SelectionChanged(object sender, EventArgs e)
        {
            Task calculateLineTask = Task.Factory.StartNew(calculateLineNumber);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            tp = tcMain.SelectedTab;
            rtbMain_TextChanged(sender, e);
            getRichTextBox(tp).Focus();       
        }

        public void closeTab(TabPage tp) {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => closeTab(tp)));
            }else{
                if (tp.Tag == null){
                    DialogResult dialogResult = MessageBox.Show("Save file ? ", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes){
                        saveFile(tp);
                        removeTab(tp);
                    }else if (dialogResult == DialogResult.No){
                        removeTab(tp);
                    }
                }else{
                    getRichTextBox(tp).SaveFile((string)tp.Tag, RichTextBoxStreamType.PlainText);
                    removeTab(tp);
                }
            }                     
        }

        public void removeTab(TabPage tp) {
            if (tcMain.TabPages.Count == 1){
                newFile();                    
            }
            tcMain.TabPages.Remove(tp);
        }

        public void closeAll() {
            TabControl.TabPageCollection tabs = tcMain.TabPages;
                       
            foreach (TabPage page in tabs){
                Task closeTask = Task.Factory.StartNew(() => {
                    TabPage tp = page;
                    closeTab(tp);
                });
                closeTasks.Add(closeTask);            
            }       
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the closeTab method in it
            Task closeTabTask = Task.Factory.StartNew(()=> closeTab(tp));
        }

        private void tsbSaveAll_Click(object sender, EventArgs e)
        {
            // create a task and start the saveAll method in it
            Task saveAllTask = Task.Factory.StartNew(saveAll);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the saveAll method in it
            Task saveAllTask = Task.Factory.StartNew(saveAll);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the closeAll method in it
            Task closeAllTask = Task.Factory.StartNew(closeAll);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll(); // close all tabs which would also save tabs
            //exit application after all tabs have been sucessfully closed
            Task.Factory.ContinueWhenAll(closeTasks.ToArray(), exit=> Environment.Exit(0));                  
        }

        private void rtbMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space){
                // create a task and start the spellCheck method in it after the populateDictionary method is completed
                var checkSpelling = dictionaryTask.ContinueWith((t) => spellCheck());
            }
        }

        private void frmSharpEditor_FormClosing(object sender, FormClosingEventArgs e)
        {            
            e.Cancel = true;//cancel application close temporarily
            closeAll();// close all tabs which would also save tabs
            //exit application after all tabs have been sucessfully closed
            Task.Factory.ContinueWhenAll(closeTasks.ToArray(), exit => Environment.Exit(0));
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the saveAs method in it
            Task.Factory.StartNew(()=>saveAs(tp));
        }

        private static byte[] VerifyKey(string key)
        {
            string password = null;
            if (Encoding.UTF8.GetByteCount(key) < 24){
                password = key.PadRight(24, ' ');
            }else{
                password = key.Substring(0, 24);
            }
            return Encoding.UTF8.GetBytes(password);
        }

        public string EncryptText(string text)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

            DES.Mode = CipherMode.ECB;
            DES.Key = VerifyKey("a1!B78s!5(");

            DES.Padding = PaddingMode.PKCS7;
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            Byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(text);

            return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public string DecryptText(string text)
        {
            try
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();

                DES.Mode = CipherMode.ECB;
                DES.Key = VerifyKey("a1!B78s!5(");

                DES.Padding = PaddingMode.PKCS7;
                ICryptoTransform DESEncrypt = DES.CreateDecryptor();
                Byte[] Buffer = Convert.FromBase64String(text.Replace(" ", "+"));

                return Encoding.UTF8.GetString(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }catch (FormatException){
                return text;
            }catch (CryptographicException) {
                return text;
            }
        }

        public void encrypyAndSave()
        {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => encrypyAndSave()));
            }else{
                getRichTextBox(tp).Text = EncryptText(getRichTextBox(tp).Text);
                saveFile(tp);
                closeTab(tp);
            }
        }

        public void decryptAndOpen() {
            if (this.InvokeRequired){
                this.Invoke(new MethodInvoker(() => decryptAndOpen()));
            }else{
                openFile();
                getRichTextBox(tp).Text = DecryptText(getRichTextBox(tp).Text);
                spellCheck();
                getRichTextBox(tp).SelectionStart = getRichTextBox(tp).Text.Length;
            }
        }

        private void encryptAndSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the encryptAndSave method in it
            Task encryptTask = Task.Factory.StartNew(encrypyAndSave);
        }

        private void decryptionAndOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a task and start the decryptAndOpen method in it
            Task decryptTask = Task.Factory.StartNew(decryptAndOpen);
        }
    }
}
