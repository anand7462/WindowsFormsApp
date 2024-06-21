Windows Forms Application in VB.NET
Overview
This project showcases a Windows Forms application developed using VB.NET. The application demonstrates effective user interface design and event handling, alongside backend communication via asynchronous HTTP requests to a TypeScript backend powered by Express.js. JSON data is serialized and deserialized using Newtonsoft.Json to facilitate seamless data exchange between the frontend and backend.

Key Learnings
1. Windows Forms Application Development
Designed and developed a Windows Forms application using VB.NET.
Focused on creating intuitive and responsive user interfaces.
Implemented event handling to manage user interactions effectively.
2. Asynchronous HTTP Requests
Utilized HttpClient to make asynchronous HTTP requests.
Communicated with a TypeScript backend powered by Express.js.
Managed data retrieval and deletion operations efficiently.
3. JSON Serialization and Deserialization
Used Newtonsoft.Json for JSON serialization and deserialization.
Ensured seamless data exchange between the frontend and backend.

Project Structure
Frontend (VB.NET) Form1: Main form to view and create submissions.
ViewSubmissionsForm: Form to view submissions with navigation controls.
CreateSubmissionForm: Form to create new submissions with a stopwatch feature.

Backend (TypeScript)
Express.js Server: Handles HTTP requests for data retrieval and submission.
Endpoints:
GET /readAll: Retrieves all submissions.
POST /submit: Creates a new submission.

How to Run
Prerequisites
.NET Framework
Node.js
npm (Node Package Manager)
Frontend Setup
Open the solution file in Visual Studio.
Build and run the Windows Forms application.
Backend Setup
Navigate to the backend directory.
Install dependencies: npm install.
Start the server: node server.js.
Usage

View Submissions:
Navigate through submissions using the "Previous" and "Next" buttons or keyboard shortcuts (Ctrl+P and Ctrl+N).
View details of each submission, including name, email, phone number, GitHub link, and stopwatch time.
Create New Submission:

Enter the required details: name, email, phone number, and GitHub link.
Use the stopwatch feature to track time, toggling between start/pause with the "Toggle" button or Ctrl+T.
Submit the form using the "Submit" button or Ctrl+S.
Conclusion
This project has significantly enhanced my skills in:

Desktop application development using VB.NET.
Frontend-backend integration with asynchronous HTTP requests.
Data management using JSON serialization and deserialization.
By developing this application, I have gained practical experience in creating robust, user-friendly applications that effectively communicate with backend services.
