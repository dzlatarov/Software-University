function solve(args) {

    for (let i = 0; i < args.length; i++) {
        if(args[i] === 'Stop') {
            break;
        } else {
            console.log(args[i]);
        }
    }
}

solve(['7', 'kuche', 'kotka', 'asdasd', '355', 'xd', 'Stop', 'luleu']);