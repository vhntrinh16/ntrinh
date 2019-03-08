package com.example.exercise;

public class UserContact extends MainActivity{
    private String name;
    private String phoneNumber;

    public String getName() {
        return name;
    }


    public void setName(String name) {
        this.name = name;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public UserContact(String name, String phoneNumber) {
        this.name = name;
        this.phoneNumber = phoneNumber;
    }
}

