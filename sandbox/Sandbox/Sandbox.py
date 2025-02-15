# Input string
scrip = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
scrip_list = {}
the_word = ""
index = 0
import random

while True:

    for char in scrip:
        if char == " ":
            scrip_list[index] = (the_word)
            index += 1
            the_word = ""
        else:
            the_word += char

    if the_word:
        scrip_list[index] = the_word

    random_number = random.randint(0, index)

    word_indices = [i for i in scrip_list if scrip_list[i] != " "]
    random_index = random.choice(word_indices)

    scrip_list[random_index] = "_____"

# Print the result
print(scrip_list)
