https://docs.mongodb.com/manual/mongo/#working-with-the-mongo-shell





## Working with the `mongo` Shell

To display the database you are using, type `db`:

 

```
db
```

The operation should return `test`, which is the default database. To switch databases, issue the `use <db>` helper, as in the following example:

 

```
use <database>
```

To list the available databases, use the helper `show dbs`. See also [`db.getSiblingDB()`](https://docs.mongodb.com/manual/reference/method/db.getSiblingDB/#db.getSiblingDB) method to access a different database from the current database without switching your current database context (i.e. `db`).

You can switch to non-existing databases. When you first store data in the database, such as by creating a collection, MongoDB creates the database. For example, the following creates both the database `myNewDatabase` and the [collection](https://docs.mongodb.com/manual/reference/glossary/#term-collection) `myCollection` during the [`insertOne()`](https://docs.mongodb.com/manual/reference/method/db.collection.insertOne/#db.collection.insertOne) operation:

 

```
use myNewDatabase
db.myCollection.insertOne( { x: 1 } );
```

The [`db.myCollection.insertOne()`](https://docs.mongodb.com/manual/reference/method/db.collection.insertOne/#db.collection.insertOne) is one of the [methods available in the mongo shell](https://docs.mongodb.com/manual/reference/method/).

- `db` refers to the current database.
- `myCollection` is the name of the collection.

If the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell does not accept the name of a collection, you can use the alternative [`db.getCollection()`](https://docs.mongodb.com/manual/reference/method/db.getCollection/#db.getCollection) syntax. For instance, if a collection name contains a space or hyphen, starts with a number, or conflicts with a built-in function:

 

```
db.getCollection("3 test").find()
db.getCollection("3-test").find()
db.getCollection("stats").find()
```

The [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell prompt has a limit of 4095 codepoints for each line. If you enter a line with more than 4095 codepoints, the shell will truncate it.

For more documentation of basic MongoDB operations in the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell, see:

- [Getting Started Guide](https://docs.mongodb.com/getting-started/shell)
- [Insert Documents](https://docs.mongodb.com/manual/tutorial/insert-documents/)
- [Query Documents](https://docs.mongodb.com/manual/tutorial/query-documents/)
- [Update Documents](https://docs.mongodb.com/manual/tutorial/update-documents/)
- [Delete Documents](https://docs.mongodb.com/manual/tutorial/remove-documents/)
- [mongo Shell Methods](https://docs.mongodb.com/manual/reference/method/)

### Format Printed Results

The [`db.collection.find()`](https://docs.mongodb.com/manual/reference/method/db.collection.find/#db.collection.find) method returns a [cursor](https://docs.mongodb.com/manual/reference/glossary/#term-cursor) to the results; however, in the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell, if the returned cursor is not assigned to a variable using the `var` keyword, then the cursor is automatically iterated up to 20 times to print up to the first 20 documents that match the query. The [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell will prompt `Type it` to iterate another 20 times.

To format the printed result, you can add the `.pretty()` to the operation, as in the following:

 

```
db.myCollection.find().pretty()
```

In addition, you can use the following explicit print methods in the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell:

- `print()` to print without formatting
- `print(tojson(<obj>))` to print with [JSON](https://docs.mongodb.com/manual/reference/glossary/#term-json) formatting and equivalent to `printjson()`
- `printjson()` to print with [JSON](https://docs.mongodb.com/manual/reference/glossary/#term-json) formatting and equivalent to `print(tojson(<obj>))`

For more information and examples on cursor handling in the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell, see [Iterate a Cursor in the mongo Shell](https://docs.mongodb.com/manual/tutorial/iterate-a-cursor/). See also [Cursor Help](https://docs.mongodb.com/manual/tutorial/access-mongo-shell-help/#mongo-shell-help-cursor) for list of cursor help in the [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell.

### Multi-line Operations in the `mongo` Shell

If you end a line with an open parenthesis (`'('`), an open brace (`'{'`), or an open bracket (`'['`), then the subsequent lines start with ellipsis (`"..."`) until you enter the corresponding closing parenthesis (`')'`), the closing brace (`'}'`) or the closing bracket (`']'`). The [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell waits for the closing parenthesis, closing brace, or the closing bracket before evaluating the code, as in the following example:

 

```
> if ( x > 0 ) {
... count++;
... print (x);
... }
```

You can exit the line continuation mode if you enter two blank lines, as in the following example:

 

```
> if (x > 0
...
...
>
```

## Tab Completion and Other Keyboard Shortcuts

The [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) shell supports keyboard shortcuts. For example,

- Use the up/down arrow keys to scroll through command history. See [.dbshell](https://docs.mongodb.com/manual/reference/program/mongo/#mongo-dbshell-file) documentation for more information on the `.dbshell` file.

- Use `<Tab>` to autocomplete or to list the completion possibilities, as in the following example which uses `<Tab>` to complete the method name starting with the letter `'c'`:

     

- ```
    db.myCollection.c<Tab>
    ```

    Because there are many collection methods starting with the letter `'c'`, the `<Tab>` will list the various methods that start with `'c'`.

For a full list of the shortcuts, see [Shell Keyboard Shortcuts](https://docs.mongodb.com/manual/reference/program/mongo/#mongo-keyboard-shortcuts)

## `.mongorc.js` File

When starting, [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) checks the user’s [`HOME`](https://docs.mongodb.com/manual/reference/program/mongo/#envvar-HOME) directory for a JavaScript file named [.mongorc.js](https://docs.mongodb.com/manual/reference/program/mongo/#mongo-mongorc-file). If found, [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) interprets the content of `.mongorc.js` before displaying the prompt for the first time. If you use the shell to evaluate a JavaScript file or expression, either by using the [`--eval`](https://docs.mongodb.com/manual/reference/program/mongo/#cmdoption-mongo-eval) option on the command line or by specifying [a .js file to mongo](https://docs.mongodb.com/manual/reference/program/mongo/#mongo-shell-file), [`mongo`](https://docs.mongodb.com/manual/reference/program/mongo/#bin.mongo) will read the `.mongorc.js` file *after* the JavaScript has finished processing. You can prevent `.mongorc.js` from being loaded by using the [`--norc`](https://docs.mongodb.com/manual/reference/program/mongo/#cmdoption-mongo-norc) option.



## Exit the Shell

To exit the shell, type `quit()` or use the `<Ctrl-C>` shortcut.