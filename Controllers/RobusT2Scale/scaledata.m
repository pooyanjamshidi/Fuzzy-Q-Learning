function dataout = scaledata(datain,minval,maxval,range)
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% Program to scale the values of a matrix from a user specified minimum to a user specified maximum
%
% Usage:
% outputData = scaleData(inputData,minVal,maxVal);
%
% Example:
% a = [1 2 3 4 5];
% a_out = scaledata(a,0,1);
%
% Output obtained:
%            0    0.1111    0.2222    0.3333    0.4444
%       0.5556    0.6667    0.7778    0.8889    1.0000

% dataout = datain - min(datain(:));
% dataout = (dataout/range(dataout(:)))*(maxval-minval);
% dataout = dataout + minval;

if datain<=range
    dataout = datain;
    dataout = (dataout/range)*(maxval-minval);
    dataout = dataout + minval;
else
    dataout=maxval;
end