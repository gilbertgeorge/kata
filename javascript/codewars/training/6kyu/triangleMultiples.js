//def get_row_sum(n):
//     total_sum = n ** 3
//     if n % 2 == 0:
//         return [total_sum, total_sum, 0]
//     else:
//         even_sum = n * (n**2 // 2)
//         return [total_sum, even_sum, even_sum + n]
//
//
// def mult_triangle(n):
//     all_sums = []
//     while n > 0:
//         row_sum = get_row_sum(n)
//         all_sums.append(row_sum)
//         n -= 1
//     return [sum(x) for x in zip(*all_sums)]

function getRowSum(n) {
    let totalSum = n ** 3;
    if (n % 2 === 0) {
        return [totalSum, totalSum, 0];
    }
    else {
        let evenSum = n * Math.floor((n ** 2 / 2));
        return [totalSum, evenSum, evenSum + n];
    }
}

function multTriangle(n) {
    let allSums = [];
    while (n > 0) {
        let rowSum = getRowSum(n);
        allSums.push(rowSum);
        n -= 1;
    }
    return allSums.reduce((acc, cur) => {
        return [acc[0] + cur[0], acc[1] + cur[1], acc[2] + cur[2]];
    });
}


console.log(multTriangle(1), [1, 0, 1])
console.log(multTriangle(2), [9, 8, 1])
console.log(multTriangle(3), [36, 20, 16])
console.log(multTriangle(4), [100, 84, 16])
console.log(multTriangle(5), [225, 144, 81])
console.log(multTriangle(6))
console.log(multTriangle(7))
console.log(multTriangle(20))
console.log()
console.log(multTriangle(5000))