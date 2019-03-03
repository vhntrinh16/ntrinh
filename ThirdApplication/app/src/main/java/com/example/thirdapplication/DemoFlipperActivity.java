package com.example.thirdapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ViewFlipper;

public class DemoFlipperActivity extends AppCompatActivity {
    ViewFlipper viewFlipper;
    Button btnNext;
    Button btnBack;
    Button Chuyen;
    int[] imageList = {R.drawable.pt,R.drawable.r};



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_demo_flipper);
        onInit();
        viewFlipper.startFlipping();
        viewFlipper.setFlipInterval(1000);
        btnNext.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                viewFlipper.showNext();
            }
        });
        btnBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                viewFlipper.showPrevious();
            }
        });
        Chuyen.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(DemoFlipperActivity.this, ModelActivity.class);
                startActivity(intent);
            }
        });

        LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, 400, 500);
        layoutParams.weight = 1.0f;
        layoutParams.gravity = Gravity.CENTER;
        for (int i:imageList){
            ImageView imageView = new ImageView(this);
            imageView.setLayoutParams(layoutParams);
            imageView.setImageResource(i);
            viewFlipper.addView(imageView);
        }
        viewFlipper.startFlipping();
        viewFlipper.setFlipInterval(1500);

    }
    private void onInit(){
        viewFlipper = findViewById(R.id.demo_viewflipper);
        btnNext = findViewById(R.id.btnNext);
        btnBack = findViewById(R.id.Preview);
        Chuyen = findViewById(R.id.btnChuyen);

    }
}
