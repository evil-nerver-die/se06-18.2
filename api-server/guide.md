## Create Your Server

All of the toy data is stored in the `db.json` file. You'll want to access this
data using a JSON server. In order to do this, run the following two commands:

   * `npm install -g json-server`
   * `json-server --watch db.json`

This will create a server storing all of our data with restful routes


        Resources
        http://localhost:3000/coins
        http://localhost:3000/stars
        http://localhost:3000/user

        Home
        http://localhost:3000
        
### Documentation
  [json-server](https://github.com/typicode/json-server)