package com.example.exercise;

import android.provider.ContactsContract;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class Main_AddContactActivity extends AppCompatActivity {
    TextView textView;
    TextView textView1;
    TextView textView2;
    TextView textView3;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main__add_contact);
        Init();
    }

    public void Init(){
        textView = findViewById(R.id.txt2);
        textView1 = findViewById(R.id.txt3);
        textView2 = findViewById(R.id.txt4);
        textView3 = findViewById(R.id.txt5);
    }

}
