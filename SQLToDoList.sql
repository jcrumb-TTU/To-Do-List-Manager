CREATE TABLE tblUsers (
	userID INT NOT NULL AUTO_INCREMENT,
    firstName VARCHAR(50),
    lastName VARCHAR(50),
    userName VARCHAR(50),
    Password VARCHAR(50),
    PRIMARY KEY (userID)
);

CREATE TABLE tblTasks (
	taskID INT NOT NULL AUTO_INCREMENT,
    taskName VARCHAR(400),
    priorityLevel INT,
    creationDate DATETIME,
    completionDate DATETIME,
    isComplete BOOL,
    userID VARCHAR(50),
    PRIMARY KEY (taskID),
    FOREIGN KEY (userID) REFERENCES tblUsers (userID)
);

CREATE TABLE tblDueDates (
	dateID INT NOT NULL AUTO_INCREMENT,
	dueDate DATETIME,
    taskID VARCHAR(50)
    PRIMARY KEY (dateID),
    FOREIGN KEY (taskID) REFERENCES tblTasks (taskID)
);