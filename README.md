**Multi UV**
I decided to use this one for the fire in the background as it constantly changes fire levels to show movement. I used this to constantly change the appearance of the fire so it looks more like its alive
This one is done in shader graph. It uses a speed variable to change how fast a sine wave alters over time. If the sine wave is positive it is one UV if negative it is the other.

<img width="263" height="283" alt="image" src="https://github.com/user-attachments/assets/cefa2fa5-a1ea-44bb-92c7-80986fe5c18d" />

**General Purpose**
I decided to give general purpose to the background map. It is basically supposed to be mountains so I put it as a rocky backdrop. This shader is quite simple but that is all that is needed it adds texture and a but of color tint to the backdrop so it appears a more warm version of the texture.

<img width="263" height="247" alt="image" src="https://github.com/user-attachments/assets/6dcb8e03-6ff2-4690-91cd-e3e114f4471e" />

**Meaningful Tiling**
I added a shader for scrolling the lava. It uses the tileing offset of the UV to add more offset infinetly over a time variable. It can allow for different speeds to mimic the movement of my lava

<img width="418" height="113" alt="image" src="https://github.com/user-attachments/assets/ad7b340d-cd18-4311-94aa-5eff9c48946f" />
