#Process Modify
###Table of Contents
* [Description](#description)
* [Videos](#videos)
* [Screenshots](#screenshots)

###Description
Process Modify is an application that manipulates RAM belonging to a process during runtime.

* You can store and name variables located at a specific memory addresses and modify them to make changes in the attached process.
* You can also edit memory directly using a hex editor. This is useful in finding addresses where specific variables are located.
* Finally, you can corrupt memory by randomizing values in a section of RAM. The memory locations that are randomized are determined by an interval and chunk size. This can yield interesting results in the behavior of the attached process.
<br>
<br>

###Videos
*Using Process Modify with an N64 emulator:*
<br>
* **Process Modify(2:45) (no sound)**<br>
[0:00](http://www.youtube.com/watch?v=SKN5lbidbXc) - Editing stored values <br>
[1:18](http://www.youtube.com/watch?v=SKN5lbidbXc&t=1m18s) - Using the hex editor to edit unknown variables <br>
[1:58](http://www.youtube.com/watch?v=SKN5lbidbXc&t=1m58s) - Corrupting memory in the hex editor <br>
[![ScreenShot](http://img.youtube.com/vi/SKN5lbidbXc/0.jpg)](https://www.youtube.com/watch?v=SKN5lbidbXc)

* **Super Mario 64 Memory Corruption(3:01) (no sound)**<br>
[![ScreenShot](http://img.youtube.com/vi/AclNAJOJo1o/0.jpg)](https://www.youtube.com/watch?v=AclNAJOJo1o)

<iframe width="854" height="510" src="" frameborder="0" allowfullscreen></iframe>
<br>
###Screenshots

* *Editing stored values*
![Alt text](SCREENSHOTS/pm0.png?raw=true "Screenshot 1")<br>

* *Using the hex editor to edit single variables*
![Alt text](SCREENSHOTS/pm2.png?raw=true "Screenshot 2")<br>

* *Corrupting chunks of memory*
![Alt text](SCREENSHOTS/pm3.png?raw=true "Screenshot 3")
