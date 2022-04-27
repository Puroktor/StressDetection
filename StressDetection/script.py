import scipy.signal as sig
import sys


# Метод Уэлча (модифицированный метод Бартлетта)
def find_spectrum(data):
    sample_rate = len(data) * 1000 / sum(data)
    return sig.welch(x=data, fs=sample_rate, detrend='constant', scaling='spectrum',
                     return_onesided=True, average='mean', window='hann')


def main():
    if len(sys.argv) == 1:
        return
    data = list(map(int, sys.argv[1:]))
    f, p = find_spectrum(data)
    for x in f:
        print(x, end=' ')
    print('\n')
    for x in p:
        print(x, end=' ')


if __name__ == '__main__':
    main()
