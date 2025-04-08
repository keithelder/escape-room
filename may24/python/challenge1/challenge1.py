import random
import threading
import time

# This is a simple output, but it it multi-threaded.
# In order to escape, you must figure out how to make it thread-safe.
# You should always get the same answer when running it.
# However, you may get different answers each time you run it.
# Good luck!


sum = 0

# lock = threading.Lock()


def add_to_sum(number):
    #    with lock:
    global sum
    temp = sum
    time.sleep(random.random())  # Simulate work
    sum = temp + number


def main():
    numbers = [1, 2, 3, 4, 5]
    threads = []

    # Create and start threads
    for number in numbers:
        thread = threading.Thread(target=add_to_sum, args=(number,))
        threads.append(thread)
        thread.start()

    # Wait for all threads to complete
    for thread in threads:
        thread.join()

    print("Total Sum is:", sum)


if __name__ == "__main__":
    main()
