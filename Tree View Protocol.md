# 24-Jul-2021

* Now getting started with the CAD Link Programming Challenge, also known as the QBuild Challenge
* As far as I understand it, the objective of this challenge is to build a desktop applications that imports and fuses the two files `bom.csv` and `part.csv` into a Database (ideally MS Access or SQL Server) and displays the imported data in a tree view.
  * In addition, when an item in the tree view is selected, information about the component parts of whatever part is currently selected in the tree view should be displayed in a table view that holds the following columns:
    * COMPONENT_NAME
    * PART_NUMBER
    * TITLE
    * QUANTITY
    * TYPE
    * ITEM
    * MATERIAL
  * The import should be performed by means of a "Populate Data" button that con only be clicked once and will then be disabled once the import is complete
* This is quite complex, and the main issue is that I haven't done an UI-Application in C# yet as far as I remember
* So, first I want to see if I can find a tutorial for how to create a Tree View in C#
  * This might be a good place to start:
    * https://www.c-sharpcorner.com/article/treeview-control-in-C-Sharp/
      * Unfortunately, I am unable to follow this tutorial past the first code sample, since it starts talking about some code without specifying where that code is supposed to be located
  * Maybe this will be better?
    * https://www.dotnetperls.com/treeview
      * **SUCCESS**: Using this tutorial I now managed to create my first, tentative working TreeView, and I am already getting ideas for how I can use this for the project
  * I am now spending some time experimenting with the tree view to get a good feeling for how it works and how I can populate it with data from a source

