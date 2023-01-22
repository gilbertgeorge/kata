# Your task in order to complete this Kata is to write a function which formats a duration,
# given as a number of seconds, in a human-friendly way.
#
# The function must accept a non-negative integer. If it is zero, it just returns "now".
# Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.
#
# It is much easier to understand with an example:
#
# * For seconds = 62, your function should return
#     "1 minute and 2 seconds"
# * For seconds = 3662, your function should return
#     "1 hour, 1 minute and 2 seconds"
# For the purpose of this Kata, a year is 365 days and a day is 24 hours.
#
# Note that spaces are important.

def format_duration(seconds):
    if seconds == 0:
        return "now"
    else:
        years = seconds // 31536000
        days = seconds % 31536000 // 86400
        hours = seconds % 86400 // 3600
        minutes = seconds % 3600 // 60
        seconds = seconds % 60
        time_list = []
        if years > 0:
            time_list.append(f"{years} year" + ("s" if years > 1 else ""))
        if days > 0:
            time_list.append(f"{days} day" + ("s" if days > 1 else ""))
        if hours > 0:
            time_list.append(f"{hours} hour" + ("s" if hours > 1 else ""))
        if minutes > 0:
            time_list.append(f"{minutes} minute" + ("s" if minutes > 1 else ""))
        if seconds > 0:
            time_list.append(f"{seconds} second" + ("s" if seconds > 1 else ""))
        if len(time_list) > 1:
            return ", ".join(time_list[:-1]) + " and " + time_list[-1]
        else:
            return time_list[0]


if __name__ == '__main__':
    print(format_duration(1))  # "1 second"
    print(format_duration(62))  # "1 minute and 2 seconds"
    print(format_duration(120))  # "2 minutes"
    print(format_duration(3600))  # "1 hour"
    print(format_duration(3662))  # "1 hour, 1 minute and 2 seconds"
    print(format_duration(15731080))  # "182 days, 1 hour, 44 minutes and 40 seconds"
    print(format_duration(132030240))  # "4 years, 68 days, 3 hours and 4 minutes"
    print(format_duration(205851834))  # "6 years, 192 days, 13 hours, 3 minutes and 54 seconds"
    print(format_duration(253374061))  # "8 years, 12 days, 13 hours, 41 minutes and 1 second"
    print(format_duration(242062374))  # "7 years, 246 days, 15 hours, 32 minutes and 54 seconds"
    print(format_duration(101956166))  # "3 years, 85 days, 1 hour, 9 minutes and 26 seconds"
    print(format_duration(33243586))  # "1 year, 19 days, 18 hours, 19 minutes and 46 seconds"
    print(format_duration(0))  # "now"

