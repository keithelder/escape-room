# This program decodes an encoded message and prints it to the console.
# In order to escape, your task is to decode the message within the array and type it into the chat.


def decode_message(data):
    msg = ""
    # for i in data:
    #    msg += chr(i - 1)
    return msg


def main():
    encoded_message = [
        78,
        122,
        33,
        119,
        112,
        106,
        100,
        102,
        33,
        106,
        116,
        33,
        110,
        122,
        33,
        113,
        98,
        116,
        116,
        113,
        112,
        115,
        117,
        47,
        33,
        87,
        102,
        115,
        106,
        103,
        122,
        47,
    ]
    message = decode_message(encoded_message)
    print("Secret Message:", message)


if __name__ == "__main__":
    main()
