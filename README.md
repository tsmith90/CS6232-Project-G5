# CS6232-Project

The purpose of this project is to have you apply the knowledge you have learned in DB I and DB II to the design and implementation of a database-driven application. Through this project, you should gain familiarity with:

the process of database design and implementation 
different techniques in interacting with DBMSs in a programming language
specifying queries in SQL DDL and DML,
using stored procedures when appropriate
2. Description
Last semester, you designed a DB for a clinic. This time, you will redesign the DB and implement an application that allows the clinic nurses and administrator to manage the patients and their visits, etc. Note that there are a few changes in the DB requirements so you will need to re-examine your design and come up with a new one within your group.

The clinic has doctors, nurses, and patients, and administrators, who have personal information, such as id (unique within their groups, for instance, a doctor has a unique doctor id, a patient has a unique patient id, if a doctor becomes a patient, a unique patient id is assigned to him/her), last name, first name, date of birth, mailing address (please break down into smaller components), and contact phone number. Each doctor has also several specialties stored in the DB.
When a patient calls in for an appointment, a nurse helps him/her first set up an appointment with a doctor on a specific date and time. The reasons for the appointment should also be specified. If the patient is new, the nurse registers him into the system first before making an appointment. The system doesn't store which user helped with registering the patient.
when creating an appointment, make sure no double booking of the same doctor at the same time
patient's personal information should also editable by a nurse
a patient may be deleted by a nurse if the patient doesn't have any appointments associated with him/her 
an appointment can be deleted if there is no visit associated with it yet (e.g. maybe the appointment is canceled)
an appointment may be editable within 24 hours before the appointment datetime.
When the patient comes in on the appointment date, a nurse does routine checks (weight with 2 decimal places, blood pressure including systolic and diastolic reading , body temperature with one decimal place, pulse) and asks him about his symptoms and records this information in the system. Note that the nurse may not be the front desk person who made an appointment for the patient. Whoever is logged in should be the nurse associated with the visit. The doctor should be the one with whom the patient made an appointment. The doctor's information should be shown in the interface.

The doctor then comes in and tries to make a diagnosis. Note that sh/e may have to order some lab tests before the diagnoses can be made. However, the initial diagnosis will first be entered.
When ordering tests, one can select which tests among a list of standard tests to order, the program should show all the tests that are ordered so that it's clear to the user. Before the order is submitted, one can remove from or add tests to the list. A confirmation message should be displayed to the user so that she can submit or cancel the order.

Lab tests may be performed on the same day of the visit or on different dates. Thus the perform datetimes of the tests have to be recorded too.  The result typically will not be available until several days later. In any case (either the tests are done on the same day or on different dates), a nurse has to record the test results and fill in the final diagnoses on behalf of the doctor. The test results can be anything (a numeric value, or a description). Each result can be normal or abnormal.

The typical tests include white blood cell (WBC), Low-Density Lipoproteins (LDL), hepatitis A test, hepatitis B test, and so on. Each test has a test code (unique), and name (unique). 

The nurses/administrators must authenticate themselves before accessing the system.
User authentication should be verified by user name and password (not just user name). The passwords should be hashed for better security.
Once logged in, the system should show who is logged in. If it's a nurse, this nurse will be the person who performs the tasks, therefore, in the UI, it should not let the user choose a nurse again. 
Other than the tasks mentioned above that a nurse can perform, a nurse can also search for a patient’s personal information and appointment information and visit information by:
date of birth,
or name(last name and first name),
or the combination of DOB and last name.
Once an appointment is found for a patient, the nurse can 
view the past and future appointment information,
edit the details of the future appointment.
Once the visit information is found for a patient, the nurse can
view the visit information (e.g. routine check results and any tests ordered and the results if available)
edit the visit by entering test results and final diagnosis. Once the final diagnosis is entered, visit information (e.g. routine checks, test results, etc.) cannot be changed and tests cannot be ordered.
To simplify the system, we omit the interface that is used by doctors. In other words, nurses do the bookkeeping work in the system (for instance, for a patient visit, recording which doctor performed the checkup and made what diagnoses, ordered what tests, the test result, etc.). 

The system should also provide an Admin interface to allow an administrator to

add/view/update a nurse. Instead of deleting a nurse, it's better to flag a nurse to be active or inactive.
to generate a report in a tabular format. The report is based on the stored procedure in project 2 from last semester. See the description below from last semester for the complete description of the SP getMostPerformedTestsDuringDates. Note that since the requirements have changed since last time, you may also need to update your stored procedure. For your information, the requirements are shown below:
Purpose: Gets the statistics that show the most performed tests during the specified period of time for the tests that were performed at least twice.

Description: Given a startdate and enddate as the parameters, For each test qualified (the test has to be performed at least twice, which may or may not be on the same patient, during the specified time period), show
test code,
test name,
the total number of times that the qualified test has been performed in the specified date range,
the total number of times that all tests have been performed in the given date range,
the percentage of the number in 3) over the number in 4),
the number of normal results for the qualified test in the specified date range,
the number of abnormal results for the qualified test in the specified date range,
the percentage of the total number of times that the test was performed on a patient in age 18-29 (at the time when the test was performed) over the total number of times that the test has been performed in the specified date range,
similarly, get the percentage of patients in age 30-39,
the percentage of patients of all other age groups (at the time when the test was performed) who took the test,
The result should be sorted in the order of the most performed to least performed tests. For tests that were performed the same number of times, sort them by their test code in descending order.

Keep in mind that you only need to provide GUIs for nurses and Admins (patients/doctors are not provided with an interface). You may pre-populate your DB with some data when you start implementing the program.
Please understand the initial specification described above may not be as complete as it should be, which is always the case in the real world. One of your tasks here is to talk to your customer, me, to unveil the details that are yet to be discovered. Please contact me if you have any questions about the requirements. The description may be elaborated based on our discussions as you, the developer and I, the customer, reach an agreement.

3. Requirements
You will apply what you have learned in Software Development I (the agile software development methods) to design and implement a database application that shall accomplish the functionality described above.

The database system you will be using is MS SQL Server DBMS on your own machine (you will need to make sure every member has the latest DB for your application since there is no centralized one. 
The development IDE is Visual Studio and the programming language is C#.
Note that the application is not web-based.
please use an iterative and incremental approach during development.
please apply appropriate software development best practices and patterns (e.g. MVC with a data access layer (DAL), etc.).
