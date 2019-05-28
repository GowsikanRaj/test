"This is a code used to create a sine graph"

import numpy as np
import matplotlib.pyplot as plt

x = 0
y = 0
X = []
Y = []
while x <= 4*np.pi:
    y = np.sin(x)
    Y.append(y)
    X.append(x)
    x += 0.01*np.pi
plt.plot(X,Y,'r')
plt.ylim(-1,1)
plt.xlim(0,4*np.pi)
plt.title('Sine graph')
plt.show()