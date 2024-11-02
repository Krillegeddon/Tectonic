# Tectonic
Solves Tectonic sudokus, sugurus

To start, specify width and height in the top. Then click Create board. N.B. I don't know how to build tables dynamically in WinForms, so there is a maximum!

In order to set known numbers from the start. Write the number you want to set in the text box (Set known value click in the grid to assign). Then, you click on the corresponding square. Sorry, but I am total noob at WinForms!

Then, you want to specify the areas. As already mentioned, I don't know how WinForms works... and the only way I found this to work: Put the mouse cursor on the square you want to start "painting" on. Hit Shift-key and move the mouse to the squares you want to include. Release shift when done! The next color is shown on label "Next color" on top. If you are not satisfied with the next color, hit the "Skip color" button.

When the board has been created, you can simply start running the algorithms. The Run One-button runs the remove-algorithms 10 times and then the first Set-algorithm. After that the Remove-algorithms again and then the other Set-algorithm.

Contact me if there are boards not solvable and I'll add more algorithms. When doing these myself manually, I have many times seen that I have to se a square to a specific value - otherwise the board is not uniquely solved. When developing this though, I have not encountered this...

# Save/Load
It is also possible to save a grid. Hit Save-button when you have created the grid... it is saved to c:\Temp\Grid.json.
You can then re-load the same grid by hitting the Load-button.

This "feature" can be cool to use if you want to experiment with the agorithms.

Note!! You can NOT use hit the Set-buttons after each other. You need to run the Remove-algorithms first!

