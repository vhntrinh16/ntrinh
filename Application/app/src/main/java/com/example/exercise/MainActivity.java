package com.example.exercise;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    List<UserContact> userContacts = new ArrayList<>();
    CustomAdapter adapter;
    ListView listView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listView = (ListView)findViewById(R.id.ListView);
        AddContacts();
        adapter = new CustomAdapter(this,R.layout.etxt, userContacts);
        listView.setAdapter(adapter);
        listView.setClickable(true);
    }

    private void AddContacts(){
        userContacts.add(new UserContact("trinh", "123"));
        userContacts.add(new UserContact("khoa doggy", "111"));
        userContacts.add(new UserContact("Tốn lù", "222"));
        userContacts.add(new UserContact("NoName", "333"));
    }

}
