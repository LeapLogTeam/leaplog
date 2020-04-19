# LeapLog

<img src="https://github.com/LeapLogTeam/leaplog/blob/master/leaplog/logo.png" alt="leaplog logo" height="200" width="400" align="left">

<br>
LeapLog is an accounting software tool that is meant to be user friendly and straightforward.
The main goal of this software project is to provide a simple introduction to
accounting for users and small businesses unfamiliar with accounting tools.

<br><br>

**_It is still heavily under development._**

<br>

## Setting up the Program
Follow these steps to make sure the user database has the correct filepath **(do this before trying to run the program!)**:

1. In Server Explorer, right-click on LoginDB.mdf and then click on Properties.
![step4](https://user-images.githubusercontent.com/48849730/77972244-6d349b80-72b6-11ea-85b2-d1ddeaff1fc3.PNG)

2. From there, you should be able to locate the correct path. Place it in the lines of code mentioned below, replacing the incorrect paths.
![step5](https://user-images.githubusercontent.com/48849730/77972256-73c31300-72b6-11ea-860c-7e2f7f52b2f1.PNG)

3. In Solution Explorer, find LoginSreen.xaml and right-click on it, then go to View Code.
![step1](https://user-images.githubusercontent.com/48849730/77972099-116a1280-72b6-11ea-841b-540504ac0192.PNG)

4. Locate the three lines with the incorrect path (they should be 44, 92, 135).
![step2](https://user-images.githubusercontent.com/48849730/77972221-60b04300-72b6-11ea-9661-caab751e3145.PNG)

5. In Solution Explorer, find LoginManager.cs and replace the path in line 22.

6. In Solution Explorer, find LeaplLogDBManager.cs and replace the path in line 19.

After you follow those steps, you should be able to run the program.

## Current Features
- Login Screen
- Journal
- T-Accounts
- Balance Sheet

## Future Features 

- Profit and Loss Statement
- Cash Flow Statement
- Visual Reports
- Help and Guidance Features

## License

We don't have one yet, but we will soon!
