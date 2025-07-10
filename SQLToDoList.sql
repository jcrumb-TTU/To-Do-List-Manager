CREATE TABLE tblUsers (
	userID VARCHAR(32) NOT NULL,
    firstName VARCHAR(50),
    lastName VARCHAR(50),
    userName VARCHAR(30),
    Password VARCHAR(32),
    PRIMARY KEY (userID)
);

CREATE TABLE tblTasks (
	taskID VARCHAR(32) NOT NULL,
    taskName VARCHAR(400),
    priorityLevel INT,
    isComplete BOOL,
    userID VARCHAR(32),
    PRIMARY KEY (taskID),
    FOREIGN KEY (userID) REFERENCES tblUsers (userID) ON DELETE CASCADE
);

CREATE TABLE tblDates (
	dateID VARCHAR(32) NOT NULL,
	dueDate DATETIME,
    taskID VARCHAR(32),
    PRIMARY KEY (dateID),
    FOREIGN KEY (taskID) REFERENCES tblTasks (taskID) ON DELETE CASCADE
);

CREATE TABLE tblSession (
	sessionID VARCHAR(32),
    Timestamp DATETIME,
    userName VARCHAR(32),
    PRIMARY KEY (SessionID),
    FOREIGN KEY (userName) REFERENCES tblUsers (userID) ON DELETE CASCADE
);