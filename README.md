# Unity Utility Scripts Collection
**Author:** Ali Suleymanli  

A collection of versatile Unity scripts for game development, including timers, clocks, and UI panel management.

---

## Scripts Included

### 1. StopWatch
- **Description:** Simple stopwatch with Start, Stop, and Restart buttons.
- **Usage:**
  1. Attach the `StopWatch` script to a GameObject.
  2. Connect your UI buttons to the corresponding functions.
  3. Display the time using Text or TMP Text component.

### 2. GameTimer
- **Description:** Activates each game scene for 1 hour within a 24-hour period.
- **Usage:**
  1. Attach `GameTimer` to a persistent GameObject.
  2. Add your game scenes to the script’s scene list.
  3. Script handles automatic scene activation and deactivation.

### 3. AnliqSaat
- **Description:** Displays real-time clocks for multiple cities: Local, London, Moscow, Paris, Tbilisi, Ankara.
- **Usage:**
  1. Attach the script to a GameObject.
  2. Assign Text or TMP Text components for each city in the Inspector.
  3. Script updates each clock automatically.

### 4. Bolumkecid
- **Description:** Switches between UI panels by enabling/disabling GameObjects.
- **Usage:**
  1. Attach the script to a GameObject.
  2. Assign panels (GameObjects) in the Inspector.
  3. Call `SwitchPanel(index)` to switch between panels.

---

## Requirements
- Unity 2020.3 or newer
- Unity UI components (TMP Text) for display

---

## License
MIT License
