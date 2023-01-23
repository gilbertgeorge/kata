mod quarter_year;
mod rock_paper_scissors;

fn main() {
    println!("Code wars Kata:");

    println!("Quarter of the year:");
    println!("Month 1: {}", quarter_year::quarter_of(1));
    // println!("Month 2: {}", quarter_year::quarter_of(2));
    // println!("Month 9: {}", quarter_year::quarter_of(9));

    println!("Rock, paper, scissors!");

    println!("{result}", result = rock_paper_scissors::rps("scissors","paper"));
    println!("{result}", result = rock_paper_scissors::rps("scissors","rock"));
    println!("{result}", result = rock_paper_scissors::rps("paper","paper"));


    println!("Done.")
}
