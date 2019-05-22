Linq To SQL3
=============

Linq To SQL3 is a fork from Linq To SQL 2. See original here [Wiki](https://github.com/FransBouma/LinqToSQL2/wiki).

This fork brings typed DbIds for primary (and foreign) keys. The idea is to have compile-time check of assignments like:

```
Order.Id = Product.Id; // this will throw a compilation error in this fork, since it's probably not what was intended
```

I've got the inspiration for typed DbIds from here: https://github.com/DigitecGalaxus/Deblazer

Deblazer only supports int data type as PK's data type. Linq2SQL3 allows any DB supported type as the underling data type to be used, in a generic way.

## How to use the example

1. Get the code
2. Create a database by running the script LinqToSQL3.Example.DataAccess\Database scripts\CreateDb.sql . Please note that this will create a db user with a default password - use at your own risk.
2. Create a connectionstrings.json file in LinqToSQL3.Example. This is the expected format:

```
{
  "DbConnectionStrings": {
    "Db1": "data source=localhost;User=myuser;Password=*****;Initial Catalog=L2S;User Instance=false;"
  }
}
```
Replace the password with whatever you used in the previous step. 

3. Compile & run the LinqToSQL3.Example project.

# How to use with your own database

1. Open the file Linq2SQL3\LinqToSQL3.Example.DataAccess\CreateDbAccess.bat and adjust the parameters to allow the script to connect to your database. 
2. Run the file from the previous point. This will create the db artifacts of your database (using of course DbId as the PK type) - you need sqlmetal and texttemplate for this - you'll get a pretty good error message if it doesn't work
3. Add the necessary files to your project (see the example I included). Compile. Be happy.
