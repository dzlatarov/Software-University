function multiplyOrDivide(args) {
    args.map(Number);

    let a = args[0];
    let b = args[1];

    if (a <= b) {
        return a * b;
    } else {
        return a / b;
    }
}

multiplyOrDivide(['3', '2']);
