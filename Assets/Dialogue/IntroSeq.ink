INCLUDE globals.ink

-> Intro

=== Intro ===
“On June 6th, 1956, the body of the Pope was discovered in the Vatican. The autopsy reported that he had died from asphyxiation. Despite this, there were no bruise marks from the suspected strangulation. Even stranger, the room was found in a disastrous state, showing signs of a struggle between the Pope and the suspect...

The investigation is still on-going, but the sudden death of the Pope has left the state of Europe in dread and confusion…” 

It’s been a week since the Pope died. With the church left in chaos, many cases are being left unchecked until the situation is resolved. Even so, it is your duty as a priest to answer the calls of those in need. You recently received a phone call from your close friend, Alessandro. From what you can remember before the call abruptly ended, he needed your help desperately.  
You peer out the window of the car. The series of bricked apartments turn into blurred afterimages as you speed up. Minutes turn to hours. A question lingers in your mind. <i>Why was Alessandro asking for help?</i> Alessandro was the last person to ever ask for help. He always remained steadfast and stubborn until the very end. And for him to beg for help? It’s suspicious to say the least. 
Nonetheless, the Bianchi residence awaits you. You approach the neighborhood. As you slide your hands across the steering wheel, a sort of instinct takes over. You know by heart the exact degree by which to turn the wheel. The curves of the street are ingrained in you. They remind you of the Bianchi family, and those warm memories take over the anxiety. 
The crunch of the leaves underneath the tires somehow overpower the sound of the engine. A slight breeze sends a  chill onto your well-clothed skin. You arrive at the familiar bricked home. It is the residence of the Bianchi family. In the front, you see the figure of Alessandro leaning against the doorway, his back seemingly dragging down against the wall.
Upon closer inspection of Alessandro, you notice that his shirt and pants are stained with blood. Both barely hanging onto his body by threads. Deep gashes line his body, gushing with blood. His eyes are surrounded by dark rings. His chest puffs erratically from his raspy and shaky breaths.

    * [What happened?]
        Alessandro: "It's Sara… You have to save her… Please."
        ->CHOICE0
    
=== CHOICE0 ===    
        
    * [What happened to her?]
        Alessandro: "She’s been taken by something evil. I managed to lock it in a cage in a basement, but…"
        -> CHOICE1
        
=== CHOICE1 ===
    
    *[Where are the kids?]
        Alessandro: "It killed them. The thing inside her. It kidnapped her. It tortured, no… slaughtered my children. That’s why I called you. You work at the Vatican, right? You can save her! You have to save Sara. I know she wouldn’t do this, and the police would take her away if I were to call them. The only way for things to be right is if you somehow get the church’s assistance to clear this up.
        
        I… I can’t do anything for my family. I need your help."
        ->CHOICE2
        
=== CHOICE2 ===

    *[Alright. I'll do my best.]
        ->BRAVE
        
    *[Fuck this shit I'm out!]
        ->COWARD
        
=== BRAVE === 
        
Alessandro's face brightens just a little with hope. He then passes out. You pick him up and place him in the car, driving off. You take him to the hospital and promptly arrive back to the home. The case of the Bianchi residence shows signs of demonic possession. However, in order to help them, you will need to meet certain <b><color=\#FF1E35>criteria</color></b> to get approval for an exorcism from the Vatican. 

It’s a rather nerve-wracking thought. You’re not particularly experienced, and you know of the dangers. Hell, you’ve seen what the thing waiting behind the door standing before you is capable of. But Alessandro’s a friend. You owe him this much. 

Will you enter?
    *[Yes]
        ->BRAVE2
    *[No]
        ->COWARD
        
        
=== BRAVE2 === 
You grip the doorknob of the home. You feel your eyelids grow heavy. Your legs begin to buckle at the weight of your body and your head sways from the sudden exhaustion. It's as if the home is draining the <b><color=\#5B81FF>energy</color></b> out of you. Alessandro lingers in the back of your mind as the will to enter the home fleets
~energy = 80
~ setButtonActive()
->END

===COWARD===
You <b><color=\#FF1E35>cowardly</color></b> run away. 
->OVER

===OVER===
Game Over!

->END
