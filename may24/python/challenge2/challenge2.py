# In order to escape, write a function that sorts an array of integers in ascending order.
# You cannot use any built-in methods or libraries.
# You can use any sorting algorithm you want, but you must implement it yourself.


def sort_array(arr):
    # Implementing the selection sort algorithm
    # Implement sorting logic here
    # You cannot use any built-in methods or libraries
    # You can use any sorting algorithm you want
    # You must implement it yourself
    # For example, you can use Bubble Sort, Selection Sort, Insertion Sort, Merge Sort, Quick Sort, etc.
    #for i in range(len(arr)):
    #    for j in range(0, len(arr) - i - 1):
    #        if arr[j] > arr[j + 1]:
    #            arr[j], arr[j + 1] = arr[j + 1], arr[j]


def main():
    numbers = [1034, 70, 230, 302, 5]
    sort_array(numbers)
    print("Sorted Numbers:", ", ".join(map(str, numbers)))


if __name__ == "__main__":
    main()
