import time
set_time = time.time()
for i in range(1, 400000):
    print (i)
print(time.time() - set_time)