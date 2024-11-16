# 10016-DevCon 2-Team 16

*Game Design Document*
### Version 1.3

## **Dodge This!**

---

### 1. **Game Concept**
A two-player dueling game where each player faces off against the other. Each player has two guns, one shoots high and one shoots low.

---

### 2. **Objective**
Players aim to hit their opponent with bullets while avoiding incoming shots.

---

### 3. **Gameplay Logic**     
- **High Shots**: Players must duck to avoid.
- **Low Shots**: Players must jump to avoid.
- **Timer**: Players must gain as many points as possible in 30 seconds to win.
- **Points**: Every time the player hits the opponent, they gain a point. The player with the most points wins.

Players can shoot an unlimited number of bullets, but bullets can only be fired at certain intervals so they don't turn into undodgeable lasers.

---

### 4. **Player Controls**     
Each player uses a joystick and two buttons.

- **Joystick**: Controls movement (Jump, and Duck)
- **Buttons**: One button shoots high, and the other shoots low.

---

### 5. **Emotional and Experiential Outcomes**

**Excitement and tension:**
- The fast-paced nature of the game keeps players excited.
- Players needing to quickly react to high and low shots creates a thrilling and intense experience.

**Competitive:**
- The head-to-head dueling format makes it very competitive.
- Having a player opponent gives the game dynamic difficulty levels depending on your opponent.

**Engagement:**
- The simple yet challenging mechanics require players to stay fully engaged.
- The combination of shooting, jumping, and ducking keeps players mentally and physically active.

---

### 6. **Design Rationale**

**Target Audience:**
- Prospective students and visitors at Mohawk College events.
- Attendees at outreach events such as Ontario College Fair and Hamilton Comic Con.

The game appeals to outreach events as it is quick and engaging, featuring simple and easy-to-learn controls. Its competitive nature appeals to everyone, making it perfect for quickly engaging visitors and leaving a fun, lasting impression. This makes it an ideal choice for college open houses, school visits, and outreach events like the Ontario College Fair and Hamilton Comic Con. The excitement the game will generate while being played could draw in more potential players and help further expand the marketing capability of the machine as a whole. We believe our game would be an exceptional choice for the demographic that the cabinet wishes to reach.

The game aims to be uniquely challenging and engaging with lots of potential replay ability.

---

### **Design Evolution & Process**

Initially, our design was for the two players/cowboys to be holding the guns and jumping and ducking while shooting. However, when making the game in Unity, we realized that jumping and ducking while shooting would change the trajectory of the bullets too much, making it too hard to dodge. Another idea was for them to hold the guns, but they could only shoot when they were on the ground. However, between jumping and ducking, it left too small of a window to be on the ground, making it too hard to shoot. The final design we landed on was having the two guns be stationary and independent from the players/cowboys, so players could jump and duck without having any issues with bullet trajectory or if they were on the ground or not. This feels like the most balanced and straightforward way to implement and to stay true to its initial design.

---

### **Citation**

- Used Raph's scene as a reference for setting up my scene.
- Copied and repurposed Raph's obstacle spawner to shoot the guns in my scene.
- Referenced movement and spawning code from my previous projects.
