#!/usr/bin/python
import RPi.GPIO as GPIO
import time
import MySQLdb
GPIO.setmode(GPIO.BCM)

GPIO.setup(5, GPIO.OUT) #output from pin 5 green
GPIO.setup(6, GPIO.OUT) #output from pin 5
TRIG = 13
ECHO = 19


GPIO.setup(TRIG,GPIO.OUT)
GPIO.output(TRIG, 0)
db = MySQLdb.connect(host="johnny.heliohost.org", # your host, usually localhost
                       user="parking1_parking", # your username
                       passwd="parking",  # your password
                       db="parking1_parking")# name of the data base

while True:
  GPIO.setup(ECHO,GPIO.IN)
  time.sleep(0.1)
  GPIO.output(TRIG, True)
  time.sleep(0.00001)
  #print "Distance Measurement In Progress"
  GPIO.output(TRIG, 1)
  time.sleep(0.25)
  GPIO.output(TRIG,0)
  while GPIO.input(ECHO)==0:
      pass
  start = time.time()
  while GPIO.input(ECHO)==1:
    pass
  stop = time.time()
  travel_time = stop-start
  dist = round ((travel_time*17000),0)

  if 2 < dist < 50:
      sql="UPDATE parkinglot SET parked=1 WHERE  location='A1'"
      print "Full"
      GPIO.output(6, GPIO.LOW)
      GPIO.output(5, GPIO.HIGH)
  else:
      sql="UPDATE parkinglot SET parked=0 WHERE  location='A1'"
      print "Empty"
      GPIO.output(5, GPIO.LOW)
      GPIO.output(6, GPIO.HIGH)

  cursor=db.cursor()
  try:
        cursor.execute(sql)
        db.commit()
  except:
      db.rollback()


GPIO.cleanup()



