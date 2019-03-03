package com.example.thirdapplication;

import android.content.Intent;
import android.net.Uri;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.telecom.Call;
import android.view.View;
import android.widget.Button;

import java.util.jar.Manifest;

public class ModelActivity extends AppCompatActivity {
    Button b;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_model);
        onCall();
        b.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent Call = new Intent(Intent.ACTION_CALL);
                Call.setData(Uri.parse("tel:0767239065"));
                startActivity(Call);
            }
        });
    }

    private void onCall(){
        b = findViewById(R.id.btnCall);
    }
}
