// Write a function called sumIntervals/sum_intervals() that accepts an array of intervals, and returns the sum of all
// the interval lengths. Overlapping intervals should only be counted once.
//
// Intervals
// Intervals are represented by a pair of integers in the form of an array. The first value of the interval will always
// be less than the second value. Interval example: [1, 5] is an interval from 1 to 5. The length of this interval is 4.
//
// Overlapping Intervals
// List containing overlapping intervals:
//
// [
//    [1,4],
//    [7, 10],
//    [3, 5]
// ]
// The sum of the lengths of these intervals is 7. Since [1, 4] and [3, 5] overlap, we can treat the interval as
// [1, 5], which has a length of 4.

function removeOverlappingIntervals(intervals) {
    let sortedIntervals = intervals.sort((a, b) => a[0] - b[0]);
    let result = [sortedIntervals[0]];
    for (let i = 1; i < sortedIntervals.length; i++) {
        if (sortedIntervals[i][0] <= result[result.length - 1][1]) {
            result[result.length - 1][1] = Math.max(result[result.length - 1][1], sortedIntervals[i][1]);
        } else {
            result.push(sortedIntervals[i]);
        }
    }
    return result;
}

function sumIntervals(intervals) {
    let reducedIntervals = removeOverlappingIntervals(intervals);
    let sum = 0;
    for (let i = 0; i < reducedIntervals.length; i++) {
        sum += reducedIntervals[i][1] - reducedIntervals[i][0];
    }
    return sum;
}

console.log(sumIntervals([[1,2], [6, 10], [11, 15]]));  // 9
console.log(sumIntervals( [[1,4], [7, 10], [3, 5]]));  // 7
console.log(sumIntervals( [[1,5], [10, 20], [1, 6], [16, 19], [5, 11]]));  // 19
console.log(sumIntervals( [[0, 20], [-100000000, 10], [30, 40]]));  // 100000030