# Prerequisites
- Download Twine (http://twinery.org/)
- Install Twison - an extension that lets you save Twine graph as a .json (https://github.com/lazerwalker/twison)
# Writing a story
- Write a story. It should be nice and interesting, but creative value has 0 impact on functionality.
- Handle links. Links are commonly at the end of a passage
  - Links are surrounded by [[]]. Text and title are separated by *|* Our example is **[[Jump of the way of the falling piano|piano_jump]]**
  - *Jump of the way of the falling piano* is what the player sees
  - *piano_jump* is what the robot sees
  - Twine will automatically create a new passage/links to an existing passage
- Handle inventory events by tag **inv** => **inv:2|-3**
  - *2* is an id of an item, defined later
  - *-3* is amount required to access a link/amount of item lost upon reaching the passage
- Handle in-story images by tag **img** => **img:awesomeness**
  - awesomeness is a name of the file (must be jpg or png)
  - before creating the story archive, image files must be in a the right directory
# Using Novint Editor
- Upload a .json with the story
- Create the items
  - **Name**. Name show ingame
  - **Icon**. Must be jpg or png. Scales automatically, but does not compress, therefore should be optimized in advance
  - If **Is Unique** is checked, the item will always show in the top HUD of Novint reader (currently the UI is optimized to show 2 items in top bar)
  - If **Bypasses Requirements** is checked, the passage can be accessed even if the player doesn't have the required amount of the item in their inventory. It also doesn't show at the links
  - _Item ID 0 is always reserved for a Bookmark - a special item, with only a name and an icon customizable_
- Upload all images
  - switch to the **Images** tab, open the folder and copy all the images there (names must match the tag)
- Create the archive by clicking the big, important looking button.
- Upload story directly to the device or on your server

## Notes
- This guide hasn't been proofread. Hell, it hasn't even been run through a spel-chacker.
- The output archive has a .nov extension. It is in fact a plain old .zip file. I just wanted it to look more fancy. You can open and edit it by an archive opener of your choice (finally the licence for winrar you bought, after your evaluation version expired will pay off)
- There is no validation
- If archive file structure is modified outside the editor tool, the archive compiles, but won't work. it's not an achievement to break the system, to rage against the machine, to prevent singularity by breaking the editor, because it's very easy
- The editor tool will be improved in the future
  - Editing passages directly in the tool
  - Validating if all the items used by the story tags has been added
  - Validating if all the images used by the story tags has been added
  Flushing unused image files upon creating the archive
