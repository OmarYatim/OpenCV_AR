var port = process.env.PORT || 4000;
var io = require('socket.io')(port);
var shortId = require('shortid'); 

console.log("server started on port " + port);

io.on('connect', function (socket) {
    console.log('connection succesful');
    var PlayerID = shortId.generate();

    socket.emit('Register',{id : PlayerID});

    socket.on('Angle_Sent', function (data) {
        console.log('rotation : ', JSON.stringify(data));
        socket.broadcast.emit('Angle_Received', data);
        })

    socket.on('disconnect', function () {
        console.log('client disconected');
    });
});