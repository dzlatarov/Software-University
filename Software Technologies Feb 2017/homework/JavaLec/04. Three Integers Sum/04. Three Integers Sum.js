function solve(numbers){
    let args = numbers[0].split(' ');
    args = args.sort(function(a,b){return a - b});

    let num1 = Number(args[0]);
    let num2 = Number(args[1]);
    let num3 = Number(args[2]);

    if (num1 + num2 == num3){
        console.log(`${num1} + ${num2} = ${num3}`);
    } else if (num1 + num3 == num2) {
        console.log(`${num1} + ${num3} = ${num2}`);
    } else if (num2 + num3 == num1) {
        console.log(`${num2} + ${num3} = ${num1}`);
    } else {
        console.log("No");
    }
}

solve();