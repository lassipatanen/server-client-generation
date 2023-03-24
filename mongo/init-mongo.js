db.createUser({
    user: 'root',
    pwd: 'hunter2',
    roles: [
        {
            role: 'readWrite',
            db: 'mongoVeroDatabase'
        }
    ]
});

db = new Mongo().getDB("mongoVeroDatabase");
db.createCollection('taxCards');
