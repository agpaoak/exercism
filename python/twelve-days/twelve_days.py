def recite(start_verse, end_verse):
    days = {
        1: 'first',
        2: 'second',
        3: 'third',
        4: 'fourth',
        5: 'fifth',
        6: 'sixth',
        7: 'seventh',
        8: 'eighth',
        9: 'ninth',
        10: 'tenth',
        11: 'eleventh',
        12: 'twelfth'
    }
    verses = [
            "twelve Drummers Drumming",
            "eleven Pipers Piping",
            "ten Lords-a-Leaping",
            "nine Ladies Dancing",
            "eight Maids-a-Milking",
            "seven Swans-a-Swimming",
            "six Geese-a-Laying",
            "five Gold Rings",
            "four Calling Birds",
            "three French Hens",
            "two Turtle Doves",
            "a Partridge in a Pear Tree"
        ]

    expected = [
                "On the ninth day of Christmas my true love gave to me: "
                "nine Ladies Dancing, "
                "eight Maids-a-Milking, "
                "seven Swans-a-Swimming, "
                "six Geese-a-Laying, "
                "five Gold Rings, "
                "four Calling Birds, "
                "three French Hens, "
                "two Turtle Doves, "
    ]

    print(expected)
