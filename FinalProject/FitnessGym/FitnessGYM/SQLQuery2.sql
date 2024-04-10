CREATE TABLE Subscribers (
    SubscriberID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255) NOT NULL,
    City varchar(255),
    subscriptionType varchar(255) NOT NULL,
    DateOfSubscription DateTime NOT NULL,
    Password varchar(8) NOT NULL ,
    PRIMARY KEY (SubscriberID)

);
CREATE TABLE Teachers (
    TeachersID int NOT NULL,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255) NOT NULL,
    LessonName varchar(255) NOT NULL,
    PRIMARY KEY (LessonName)

);
CREATE TABLE Courses(
    CodeCourse int NOT NULL,
    Name varchar(255) NOT NULL,
    Max_participants int NOT NULL,
    Day varchar(255) NOT NULL,
    PRIMARY KEY(CodeCourse),
    CONSTRAINT FK_Teachers_Courses FOREIGN KEY(Name) REFERENCES Teachers(LessonName)
);
CREATE TABLE Schedule(
    Date DateTime NOT NULL,
    Code_schedule int NOT NULL,
    CodeCourse int NOT NULL,
    PRIMARY KEY(Code_schedule),
    CONSTRAINT FK_Schedule_Courses FOREIGN KEY(CodeCourse) REFERENCES Courses(CodeCourse)
);
CREATE TABLE participants_in_the_course(
    Code_participant int NOT NULL,
    Code_schedule int NOT NULL,
   CONSTRAINT FK_participants_in_the_courseSubscribers FOREIGN KEY (Code_participant) REFERENCES Subscribers(SubscriberID),
   CONSTRAINT FK_participants_in_the_courseSchedule FOREIGN KEY (Code_schedule) REFERENCES Schedule(Code_schedule),
    
);

