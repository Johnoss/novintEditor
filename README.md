# Prerequisites
1. Download Twine (http://twinery.org/)
2. Install Twison - an extension that lets you save Twine graph as a .json (https://github.com/lazerwalker/twison)
# Writting a story
1. Write a story
2. Handle inventory events by tag inv => inv:2|-3
  a) 2 is an id of an item, defined later
  b) -3 is amount required to access a link/amount of item lost upon reaching the passage
3. Handle in-story images by tag img => img:awesomness
  a) awesomness is a name of the file (must be jpg or png)
  b) before creating the story archive, image files must be in a the right directory
# Using Novint Editor
1. Upload a .json with the story
2. Create the items
  a) Name
  b) Icon
  c) If Is Unique is checked, the item will always show in the top HUD of Novint reader (currently the UI is optimized to show 2 items in top bar)
  d) If Bypasses Requirements is checked, the passage can be accessed even if the player doesn't have the required amount of the item in their inventory. It also doesn't show at the links
  c) Item ID 0 is always reserved for a Bookmark - a special item, with only a name and icon customizable
3. Upload all images
  a) switch to the Images tab, open the folder and copy all the images there (names must match the tag)
4. Create the archive by clicking the big, important looking button.
5. Upload story directly to the device or on your server
