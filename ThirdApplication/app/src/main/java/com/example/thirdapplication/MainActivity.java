package com.example.thirdapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import android.widget.ViewFlipper;

public class MainActivity extends AppCompatActivity {
    EditText edtUsername;
    EditText edtPasswword;
    Button btnLogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        onInit();
        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                    onLogin();
            }
        });

    }

    private void onLogin() {
        if (edtUsername.getText().toString().equals("admin") && edtPasswword.getText().toString().equals("1111")) {
            Toast.makeText(MainActivity.this, "Login Success", Toast.LENGTH_LONG).show();
            Intent intent = new Intent(MainActivity.this,DemoFlipperActivity.class);
            startActivity(intent);
        }

        else{
                Toast.makeText(MainActivity.this, "Login fail", Toast.LENGTH_LONG).show();
            }

        }

    private boolean onValidateForm(){
        if(edtUsername.getText().toString().length() < 1){
            edtUsername.setError("Please fill user");
            return false;
        }
        if(edtPasswword.getText().toString().length() < 1){
            edtPasswword.setError("Please fill user");
            return false;
        }
        return true;
    }

    private void onInit(){
        edtUsername = findViewById(R.id.main_Username);
        edtPasswword = findViewById(R.id.main_password);
        btnLogin = findViewById(R.id.btnLogin);

    }

}

