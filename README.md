# Metz-Duncan Jeopardy 
A custom Jeopardy game built for The Metz-Duncan Engagement Party on 10/24/2020.

## Overview:  
Metz-Duncan Jeopardy is a simple Jeopardy style game with questions written by the bride. This was a quicky and dirty application that was pulled together over the course of a weekend. It mostly served as way to keep me sharp on my Unity skills and gave me an oppurtunity to dive a little deeper into UI, since it is admittedly one of my weak areas. This project was built with one thing in mind - simplicity.  

#### Data Box:  
**Engineers:** Deven Fafard  
**Platform:** PC, Mac  
**Engine:** Unity 2019.4.12f


## Game Description:  
#### Gameplay  
We pared down the core mechanics of Jeopardy to the most engaging aspect - getting people to answer questions. At the party, the game was displayed on an outdoor projector screen. Party guests were randomly split into 3 teams, designated by small auction style signs. Participants "buzzed in" by holding up their signs and answering on behalf of their team.  

The controller scheme is as follows:  
**Select Question:** left click  
**Dismiss Question:** [Space] 
**Start Game:**  [Enter]  
**Exit Game:** [Exit]  
**Give Points to Team A:** [1]  
**Give Points to Team B:** [2]  
**Give Points to Team C:** [3]  



## Post Mortem:  
#### What tasks were accomplished?  
The main mechanic of Jeopardy was implemented. The ability to  were finished before Week 5. This included gameplay through Level 1. Various demo / internal ‘scratch work’ was repurposed to create Level 2. A major project refactor was completed around Week 9 in order to facilitate an easier merge of the two levels in the final weeks.

#### What planned tasks were not done?  
Player objects, daily doubles, question timers, and many other tasks were not completed. Since we were playing this outside, it didn't make sense to make it as complex as a real Jeopardy game. Eventually, I want to revisit this project and give it a proper tune-up.

#### What would we do differently?  
Given a do-over, we would like to focus less on incorporating art assets early in development, as this led to an incoherent art style and impeded engineering efforts. We would also pay more attention to how we set up the repository before any work began so as not to “stomp” previously completed work or lose object references.
