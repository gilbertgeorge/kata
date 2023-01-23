# Write a function that when given a URL as a string,
# parses out just the domain name and returns it as a string. For example:
#
# * url = "http://github.com/carbonfive/raygun" -> domain name = "github"
# * url = "http://www.zombie-bites.com"         -> domain name = "zombie-bites"
# * url = "https://www.cnet.com"                -> domain name = cnet"
import re


def domain_name(url):
    domain = re.search(r"^(?:https?:\/\/)?(?:www\.)?([^\/\?#]+)", url)
    if domain:
        return domain.group(1).split(".")[0]


if __name__ == '__main__':
    print(domain_name("http://github.com/carbonfive/raygun"))  # github
    print(domain_name("http://www.zombie-bites.com"))  # zombie-bites
    print(domain_name("https://www.cnet.com"))  # cnet
    print(domain_name("www.xakep.ru"))  # xakep
    print(domain_name("http://google.co.jp"))  # youtube
