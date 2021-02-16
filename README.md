# UniversityTest

In case of DB error/Missing on MVC start, there is an alternative to fix it:
 - In Solutions Explorer, open the file "UniversityDB.publish.xml" that is in "01.Database">Project "UniversityDB"
 - In window prompt just click Publish. After that some Green validation will appear on console just to confirm that operation is done.
 - If DB local Path changed manually, it need to be changed on web.config and app.config.
 
 After that, just run the MVC Project. Any publish of DB will reset data too.
 
