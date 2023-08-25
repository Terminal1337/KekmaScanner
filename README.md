@@ -0,0 +1,42 @@
# KekmaScanner
Find Backend Address Of Websites Behind A CDN with Ease!!

![image](https://user-images.githubusercontent.com/95563109/235135693-7e635a1d-50f2-4919-b37b-53cfee6ef4b1.png)


```
Use Case : Find RealTime Backend IPs from RealWorld Websites hiding behind a CDN or reverse http proxy.
```
```
How to Use:-

PreRequisites :-
a) Zmap
b) Port 80 Scanned
```

```
Linux :-
a) apt install zmap -y
b) zmap -p 80 -q -o 80.txt
```

```
Tutorial:-
1) Put The IPs from the scanned list (80.txt) in address field of the program 
2) set the hostname in target. For Example google.com
3) Set the Regex,i.e, Part of Response body.(For Example, Open https://google.com and copy a small static object and paste it)
4) Timeout - Timeout for http client in seconds. (Suggested : 5)
5) Run Scan
```
Disclaimer:-

We Do Not Promote Any Illegal Activities by the Use of this Software, You are Solely responsible for what you to do with the program.
```
