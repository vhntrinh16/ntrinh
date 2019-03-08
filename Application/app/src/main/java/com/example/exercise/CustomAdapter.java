package com.example.exercise;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.List;

public class CustomAdapter extends ArrayAdapter<UserContact>{
    List<UserContact> list;
    int GroupID;
    Context context;

    public CustomAdapter(Context context, int vg, List<UserContact> list) {
        super(context, vg, list);//gọi là hàm cha
        this.list = list;
        GroupID = vg;
        this.context = context;
    }
    class Viewholder{
        TextView textView1;
        TextView textView2;
        Button button;
        ImageView imageView;
    }
    @Override
    public View getView(final int position, final View convertView, final ViewGroup parent){

        View rowView = convertView;
        Viewholder viewholder = new Viewholder();
        final UserContact userContact = getItem(position);
        if(rowView == null){
            rowView = LayoutInflater.from(getContext()).inflate(GroupID, parent, false);
            viewholder.textView1 = rowView.findViewById(R.id.txt);
            viewholder.textView2 = rowView.findViewById(R.id.txt1);
            viewholder.button = rowView.findViewById(R.id.btn);
            viewholder.imageView = rowView.findViewById(R.id.Icon1);
        }
        else {viewholder =(Viewholder) rowView.getTag();}

        viewholder.textView1.setText(userContact.getName());
        viewholder.textView2.setText(userContact.getPhoneNumber());
        viewholder.button.setTag(userContact.getCallingActivity());
        rowView.setTag(viewholder);

        viewholder.button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(Intent.ACTION_CALL, Uri.parse("tel:" +userContact.getPhoneNumber()));
                context.startActivity(intent);
            }
        });
        viewholder.imageView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });
        return rowView;

    }


}
