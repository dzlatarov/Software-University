function solve(cunt){
    let args = cunt[0].split(' ');

    let num1 = Number(args[0]);
    let num2 = Number(args[1]);
    let num3 = Number(args[2]);

    if (!(num2 + num3 == num1)) {
        if (!(num1 + num3 == num2)){
            if (!(num1 + num2 == num3)) {
                console.log(args[0]);
            } else {
                console.log(`${num1} + ${num2} = ${num3}`)
            }
        } else {
            console.log(`${num1} + ${num3} = ${num2}`);
        }
    } else {
        console.log(`${num2} + ${num3} = ${num1}`);
    }
}