public class Conversion {
    private float km_conv(float value, String output_type){
        switch(output_type){
            case "km": break;
            case "m" : {value *= 1000; break;}
            case "sm": {value *= 100000; break;}
            case "mm": {value *= 1000000; break;}
            case "dc": {value *= 10000; break;}
        }
        return value;
    }
    private float m_conv(float value, String output_type){
        switch(output_type){
            case "km": {value /= 1000; break;}
            case "m" : { break;}
            case "dc": {value *= 10; break;}
            case "sm": {value *= 100; break;}
            case "mm": {value *= 1000; break;}
        }
        return value;
    }
    private float dc_conv(float value, String output_type){
        switch(output_type){
            case "km": {value *=  0.0001; break;}
            case "m" : { value *= 0.1; break;}
            case "dc": { break; }
            case "sm": {value *= 10; break;}
            case "mm": {value *= 100; break;}
        }
        return value;
    }
    private float sm_conv(float value, String output_type){
        switch(output_type){
        case "km": { value *= 0.00001 ; break;}
        case "m" : { value *= 0.01; break;}
        case "dc": { value *= 0.1; break; }
        case "sm": { break;}
        case "mm": { value *= 10; break;}
        }
        return value;
    }
    private float mm_conv(float value, String output_type){
        switch(output_type) {
        case "km": { value *= 0.000001 ; break;}
        case "m" : { value *= 0.001; break;}
        case "dc": { value *= 0.01; break; }
        case "sm": { value *= 0.1; break;}
        case "mm": { break;}
        }
        return value;
    }

    public float convert(String input_type, String output_type,
                         float value){
        float res = 0;
        switch(input_type){
            case "km": {res = km_conv(value, output_type); break;}
            case "m": {res = m_conv(value, output_type); break;}
            case "dc": {res = dc_conv(value, output_type); break;}
            case "sm": {res = sm_conv(value, output_type); break;}
            case "mm": {res = mm_conv(value, output_type); break;}
        }
        return res; }
}
