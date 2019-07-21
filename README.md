# Object Linking and Embedding Database (OLE DB)

Object Linking and Embedding Database (OLE DB) is a group of APIs used to facilitate and abtract access to application data of different file formats, including spreadsheets, structured query language (SQL)-based database management systems (DBMS), indexed-sequential files, and personal databases.

OLE DB is based on the Component Object Model (COM) and is part of the Microsoft Data Access Components (MDAC) software package, which is used to read and write data.
An application using OLE DB would use this request sequence:

Initialize OLE.
1)Connect to a data source.
2)Issue a command.
3)Process the results.
4)Release the data source object and uninitialize OLE.
