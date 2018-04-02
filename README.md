# NotepadSharpEditor
A text editor application using C# with task based programming functionalities.

Text Editor Application (SharpEditor)

Notepads are basic text editing programs which enables computer users to create, open, and read documents. Notepad and Notepad++ is included with Microsoft Windows. Notepad++ supports tabbed editing (working with multiple open files in a single window). This application is a text editor application using C# (SharpEditor) with task based programming functionalities available in C#.  

Functional Requirements
Following are the required functionalities that are implemented in the SharpEditor application. Identified areas and scenarios include task based programming features.  

1.	Opening SharpEditor applications – User should be able to open a SharpEditor application and to create new SharpEditor instances as tabs with the FileNew menu item. Every tab is a separate instance of SharpEditor.
2.	Typing: User should be able to type using the keyboard and the application needs to print it inside the editor. This should not be freeze due to any other action.  
3.	Spell check: Real time spell checking engine should be implemented to conduct a spell check while user typing in the editor. You can use the word set available at http://www.albahari.com/ispell/allwords.txt to create the dictionary. The spell checker should be implemented as a parallel checker. 
4.	Auto Save: The document should be automatically saved while user working on the document. Saving of the document should not interrupt any other functions while it is saving. 
5.	Basic Text Operations: Common text operations such as Bold, Italic, underline..etc. should be available.  
6.	Word count display: Real-time word count need to be display at the bottom pane of the application.
7.	Length: Real-time length of the text should be display at the bottom pane of the application.
8.	Line Number: Real-time line number should be display at the bottom pane of the application. 
9.	Encrypt: Encryption of the document content. This should be able to execute as a separate action.  
10.	Save All: Ability to save all the open instances at once. To be efficient this should execute the saving operation concurrently
