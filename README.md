# Prerequisites
- Download Twine (http://twinery.org/)
- Install Twison - an extension that lets you save Twine graph as a .json (https://github.com/lazerwalker/twison)
# Writting a story
- Write a story. It should be nice and interesting, but creative value has 0 impact on functionality.
- Handle inventory events by tag inv => inv:2|-3
  - 2 is an id of an item, defined later
  - -3 is amount required to access a link/amount of item lost upon reaching the passage
- Handle in-story images by tag img => img:awesomness
  - awesomness is a name of the file (must be jpg or png)
  - before creating the story archive, image files must be in a the right directory
# Using Novint Editor
- Upload a .json with the story
- Create the items
  - Name. Name show ingame
  - Icon. Must be jpg or png. Scales automatically, but doesnt compress, therefore should be optimized in advance
  - If Is Unique is checked, the item will always show in the top HUD of Novint reader (currently the UI is optimized to show 2 items in top bar)
  - If Bypasses Requirements is checked, the passage can be accessed even if the player doesn't have the required amount of the item in their inventory. It also doesn't show at the links
  - _Item ID 0 is always reserved for a Bookmark - a special item, with only a name and icon customizable_
- Upload all images
  - switch to the Images tab, open the folder and copy all the images there (names must match the tag)
- Create the archive by clicking the big, important looking button.
- Upload story directly to the device or on your server
