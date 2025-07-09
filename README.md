# To-Do-List-Manager
This app is made to be a basic to do list Manager that allows a user to add, read, edit, and delete tasks, as well as set their priority. This project is made using windows forms and MySQL Database.

A NOTE ON DATABASE CONNECTIONS IN THE FORMS

The way that I am using connection strings to connect to the database in the main components of the application is not best practice nor is it how I would do so were I creating an application that would interact with an end user in practice. This would, in an ideal course of events, be done using seperate config files that would contain the connection strings or better yet exist as an encrypted file that the application would connect to away from the end user. Additionally, I would likely create a seperate file with classes and methods that would perform the basic CRUD operations to improve security and add defensive layering to the application itself. I have made the choice to show my connections openly to demonstrate understanding of how to connect to, read, create, update, and delete entries within a database.

A NOTE ON PASSWORDS IN THE DATABASE

Ideally I would not have any passwords stored in the database as plain text, as this would be a massive security issue within the the application and would be easy to exploit. This decision was made for the time being for simplicities sake, as there is limited time I have to do everything I would like or would be exactly best practice. Ideally I would encrypt passwords into the database and using password hashes instead and add an encryption and decryption key to allow passwords to remain secure.