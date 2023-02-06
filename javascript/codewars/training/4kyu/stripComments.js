// Complete the solution so that it strips all text that follows any of a set of comment markers passed in.
// Any whitespace at the end of the line should also be stripped out.
//
// Example:
//
// Given an input string of:
//
// apples, pears # and bananas
// grapes
// bananas !apples
// The output expected would be:
//
// apples, pears
// grapes
// bananas
// The code would be called like so:
//
// var result = solution("apples, pears # and bananas\ngrapes\nbananas !apples", ["#", "!"])
// // result should == "apples, pears\ngrapes\nbananas"


function solution(input, markers) {
    let lines = input.split('\n');
    let result = [];
    for (let line of lines) {
        let lineResult = line;
        if (markers.some(marker => lineResult.indexOf(marker) !== -1)) {
            let marker = markers.find(marker => lineResult.indexOf(marker) !== -1);
            let markerIndex = lineResult.indexOf(marker);
            lineResult = lineResult.slice(0, markerIndex).trim();
        }
        result.push(lineResult);
    }
    return result.join('\n');
}

console.log(solution("apples, pears # and bananas\ngrapes\nbananas !apples", ["#", "!"]));  // "apples, pears\ngrapes\nbananas"
console.log(solution("a #b\nc\nd $e f g", ["#", "$"]));  // "a\nc\nd"
console.log(solution("Q @b\nu\ne -e f g", ["@", "-"]));  // "Q\nu\ne"
