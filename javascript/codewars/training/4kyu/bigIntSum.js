function add(a, b) {
    // remove initial 0's
    a = a.replace(/^0+/, '');
    b = b.replace(/^0+/, '');
    const aLength = a.length;
    const bLength = b.length;
    const maxLength = Math.max(aLength, bLength);

    let carry = 0, sum = '';

    for (let i = 1; i <= maxLength; i++) {
        let x = Number(a.charAt(aLength - i));
        let y = Number(b.charAt(bLength - i));

        let colSum = carry + x + y;
        carry = colSum / 10 | 0;
        colSum %= 10;

        sum = (i === maxLength && carry)
            ? carry*10 + colSum + sum
            : colSum + sum;
    }

    return sum;
}


console.log(add("1", "1"));  // "2"
console.log(add("123", "456"));  // "579"
console.log(add("888", "222"));  // "1110"
console.log(add("1372", "69"));  // "1441"
console.log(add("12", "456"));  // "468"
console.log(add("101", "100"));  // "201"
console.log(add('63829983432984289347293874', '90938498237058927340892374089'));  // "91002328220491911630239667963"
