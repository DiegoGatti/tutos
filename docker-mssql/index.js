const sql = require('mssql');

var config = {
    user: 'sa',
    password: 'UnChanchit0',
    server: 'localhost', 
    database: 'testdb',
    options: { 
        trustServerCertificate: true,
    }
};

const run = async() => {
    let pool;

    try {
        console.log('Opening connection...');

        pool = await sql.connect(config);
        const { recordset } = await sql.query`select * from users;`;

        console.log(recordset);
    } catch (err) {
        console.log(err);
    } finally {
        await pool.close();
        console.log('Connection close.');
    }
}

run();