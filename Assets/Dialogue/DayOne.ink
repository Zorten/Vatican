INCLUDE globals.ink

#layout:dialogue #room:none
You grip the doorknob of the home. You feel your eyelids grow heavy. Your legs begin to buckle at the weight of your body and your head sways from the sudden exhaustion. It's as if the home is draining the <b><color=\#0CAC5C>energy</color></b> out of you. Alessandro lingers in the back of your mind as the will to enter the home fleets.

<b><color=\#B80000>Entrance Room DAY ONE</color></b>

->ENTRANCE_ROOM
    
===ENTRANCE_ROOM===
#layout:navigation #room:Entrance Room #choice:link
The light drains from the room as you shut the door behind you. The doorknob is wet with blood, and you instinctively curl your fingers with a shudder. A horrific stench seems to permeate the air, coating the roof of your mouth. Your hands start to become numb. It’s cold, and the blood on your hand is drying fast. There's only the <link="frontdoor"><b><color=\#000000>front door</link></b></color> behind you and an <link="doorway"><b><color=\#000000>open doorway</link></color></b> before you, leading deeper into the house. 

    +[Front door]
        ->FRONT_DOOR
        
        
    +[Open Doorway]
        Trepidation churns in your gut, but at the moment, you have your life and Alessandro’s freedom riding on this. You step through the open doorway despite every instinct in your body screaming for you to do otherwise. You really need to do what you came here to: collect evidence.
        You've entered a dark hallway, and you get the unsettling sense that you're on your own, but you are absolutely not alone.
        ->DOWNSTAIRS_HALLWAY
        
===FRONT_DOOR===
#room:Front Door #choice:box
You decide to leave for fresh air. You need more time to steel yourself for this. 
    +[Entrance]
        ->ENTRANCE_ROOM

===DOWNSTAIRS_HALLWAY===
#room:Downstairs Hallway #choice:link
At the end of the hallway is a staircase to the <link="upstairshall"><b><color=\#000000>upstairs hallway</link></color></b>. The light of the lamp glistens upon the shiny wooden floor. Near you, the springs of the grandfather clock ticking echo throughout the quiet home. It goes into the <link="livingroom"><b><color=\#000000>living room</link></color></b>. Looking into the hallway, you see doors to the <link="bathroom"><b><color=\#000000>bathroom</link></color></b>, <link="closet"><b><color=\#000000>closet</link></color></b>, <link="office"><b><color=\#000000>office</link></color></b>, and <link="basement"><b><color=\#000000>basement</link></color></b>. There’s something eerie about the basement door. Across from the bathroom door is the entryway to the <link="kitchen"><b><color=\#000000>kitchen</link></color></b>.
    
    +[Upstairs Hallway]
        <color=\#B80000>You see a girl sitting in front of the nursery door.</color>
        ->UPSTAIRS_HALLWAY
    
    +[Living Room]
        ->LIVING_ROOM
        
    +[Bathroom]
        ->DOWNSTAIRS_BATHROOM
        
    +[Closet]
        ->CLOSET
        
    +[Office]
        ->OFFICE
    
    +[Basement]
        ->BASEMENT
        
    +[Kitchen]
        ->KITCHEN
        
    
===UPSTAIRS_HALLWAY===
#room:Upstairs Hallway #choice:link
Stepping into the hallway, you hear the soft chime of the clock on the wall. At the end of the hallway lies a window and houseplant. Through the window, moonlight illuminates the shaggy brown carpet. Some parts seem to be stained with a darker brown. On the hallway walls are four doors. Nearest to you is the<link="nursery"><b><color=\#000000>nursery</link></color></b>. On the same wall are the <link="masterbedroom"><b><color=\#000000>master bedroom</link></color></b> and balcony doors. On the opposite side is the <link="bathroom"><b><color=\#000000>bathroom</link></color></b>. <link="downstairs">downstairs</link>


    +[Nursery]
        ->NURSERY
    
    +[Master Bedroom]
        <color=\#B80000>You enter the room and see a girl laying on the bed. She’s laying on her side. You can hear her crying from across the room.</color>
        ->MASTER_BEDROOM
        
    +[Bathroom]
        ->UPSTAIRS_BATHROOM
        
    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===LIVING_ROOM===
#room:Living Room #choice:box
A red carpet is set over wooden floors, various forgotten children's toys scattered on top of it, including a wooden rocking horse. The grandfather clock in the corner ticks quietly. In one corner, a record player sits on a desk, and across the room are two sets of couches.
    
    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===DOWNSTAIRS_BATHROOM===
#room:Downstairs Bathroom #choice:box
The room is at least an arms length. At the end of the room lies a small shower. Hair appears to clog the drain. Though the toilet lid is closed, a strong stench tells you that it has not been flushed.The mirror is smudged and dirty. The sink itself is stained with brown spots.
    
    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===CLOSET===
#room:closet #choice:box
I wasn't given a description for the closet.

    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===OFFICE===
#room:Office #choice:box
Toward the back of the room, you can see a dark wooden desk, a myriad of items littering its surface, including a camera. Behind it, there is a window with its curtains partially opened, allowing natural light to fill the room. There is a bookshelf in the corner by the window with various books lining its shelves. To your right, you can see a worn black couch with a lamp next to it. A thin layer of dust coats everything.

    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===BASEMENT===
#room:Basement #choice:box
The smell of rot and death permeates the stale air trapped within the bloodstained concrete of the basement. It's dim in spite of the lamp on the desk and the ceiling light, but it's enough to cast light on the cage in the center of the room, iron bars holding strong against its captive. Behind it, you can see a washing machine and a dryer. A lone wooden chair is situated in front of the cage, just out of arm's reach from the bars of the cage.

    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===KITCHEN===
#room:Kitchen #choice:box
There is a wooden island in the center of the tiled floors. A set of cupboards are in the back corner by the window over the sink and stove. To the right of it, you can see a refrigerator.

    +[Downstairs Hallway]
        ->DOWNSTAIRS_HALLWAY

===NURSERY===
#room:Nursery #choice:box
There are two beds in the nursery, one child-sized and the other a little more appropriate for a young teenager, a nightstand between the two of them. A wooden box is at the foot of the smaller bed, brimming with toys, and a little rocking horse rocks itself silently. The curtains of the window are partially open, letting moonlight filter into the room and illuminate the dark crimson that almost seems to drench the space, dying the sheets and floor a red so dark it's almost black.

    +[Upstairs Hallway]
        ->UPSTAIRS_HALLWAY

===MASTER_BEDROOM===
#room:Master Bedroom #choice:link
You enter the Master Bedroom. 

A cold breeze brushes against your skin. The <link="balcony door"><b><color=\#000000>balcony door</link></color></b> is ajar. Despite this, the room radiates a warm aura as you look around. The queen-size bed lies on a thin iron frame. The <link="take bed sheets"><b><color=\#000000>bed sheets</link></color></b> are neatly folded and clean. A white wardrobe stands firmly. Even in the darkness, the white paint glows brightly. In the other corner lies a white vanity mirror. Its shade is only slightly darker than that of the wardrobe. The mirror is spotless. Your eyes finally meet the object at the end of the bed. A footlocker covered in rust and dirt. You see splotches of brown on the handles of the footlocker. Dried blood that couldn’t be cleaned off during the war. 

    +[Balcony]
        ->BALCONY
        
    *[Take Bed Sheets]
        It feels as if it’s singing to you, luring you into its soft sheets to rest. Even across the room, you can smell its fresh linen melting away your tension. You walk to the iron bed frame. You remove the sheets from the mattress. You feel safe as your hands grasp the comfortably cold linen. The room looks empty now.
        ->UPSTAIRS_HALLWAY
        
    +[Upstairs Hallway]
        ->UPSTAIRS_HALLWAY
        
===UPSTAIRS_BATHROOM===
#room:Upstairs Bathroom #choice:box
Upon opening the door, a strong chlorine smell clogs your nose. Though the room is pitch black, the white tub glows with little light. It stands on tiny metal bronze legs. Its white ceramic shell looks unstained and thoroughly cared for. A vanity mirror with a golden arch and sink stands near the door. On it lies numerous cleaning products. In between the tub and sink lies a white toilet. 

    +[Upstairs Hallway]
        ->UPSTAIRS_HALLWAY

===BALCONY===
#room:Balcony #choice:box
Stepping outside gives you a sense of relief. The sound of crickets chirping, the wind flowing, and the moon glowing in the night sky gives you a moment of peace. On the balcony railing, you see potted plants and a <b><color=\#000000>thermometer</color></b>.
    
    +[Master Bedroom]
        ->MASTER_BEDROOM

    

-> END
    