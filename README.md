# Unity3D Industrial Robotics: Universal Robots UR3 + UR5 (Tested)

## Project Description:

The project is focused on a simple demonstration of client-server communication via TCP / IP, which is implemented in Unity3D. The project demonstrates the Digital-Twin of the UR3 robot with some additional functions. The application uses performance optimization using multi-threaded programming.

This solution can be used to control a real robot or to simulate it (using VMware <-> UR Polyscope), E and CB series. The Unity3D Digital-Twin application was tested on the UR3 robot, both on real hardware and on simulation.

Main functions of the UR3 Digital-Twin model:
- Camera Control
- Connect/Disconnect -> Real HW or Simulation
- Read Data (Cartesian / Joint Position diagnostics)
- Write Data (Speed control of the robot (X,Y,Z and EA{RX, RY, RZ}) using the joystick)

The application can be installed on a mobile phone(tested), tablet or computer(tested), but for communication with the robot it is necessary to be in the same network.

<p align="center">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_1.PNG" width="800" height="500">
</p>

## UI 

<p align="center">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_h.PNG" width="800" height="500">
</p>

## Digital-Twin Application:

<p align="center">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_dt_1.png" width="800" height="500">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_dt_2.png" width="800" height="500">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_dt_3.png" width="800" height="500">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_dt_4.png" width="800" height="500">
<img src="https://github.com/rparak/Unity3D_Robotics_UR/blob/main/images/ur_rh_1.png" width="800" height="500">
</p>
