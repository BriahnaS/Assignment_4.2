# Mini Learning Management System

## Purpose
```
* Allow a teacher to login, add students (with data like student Id, Student Name, and GPA) and delete students
* Save highest GPA student's details in a text file
```
## Language, Framework, and App Type
```
* C#
* .Net 10 
* Windows Forms
```

## Custom Data Types
```
* Enum: User
* Classes: 
    - User (Parent)
    - Teacher
    - Student
```

## Preliminary Solution Structure
```
* Create parent and child classes with necessary properties
    - Establish mock data
* Design main page with hidden data and login button
    - Develop login method and user and password verification methods inside event handler for login button within a pop up
    - Start SessionContext 
    - Create method to display hidden data upon successful login verification
* Allow user to click on:
    - Add student
        -- Establish event handler to create pop up for student information (properties) to add
    - A student and delete them
        -- Create event handler for when a student is selected
        -- Show student data
        -- Provide options to delete
    - Star Pupil button
        - Program event handler with a foreach loop to determine which student has the highest GPA
        - Use StreamWriter to create a text file with the Star Pupil's data
```

## Planned Development Time: ~*4 hours*