function vector=update_net(q,action,state,vector)
%% update the neural netwrok, a simple neuron (linear neural network of two input nodes and one output nofr) as a function approximator
% approximated function is a plane with a constant 1 and one independent variable "state", weights are vector(action,1) and vector(action,2)
% we implemented Incremental Widrow-Hoft algorithm: http://homepages.gold.ac.uk/nikolaev/311Delta.htm

% This implementation is mostly inspired by the book: http://books.google.ie/books?id=XqKyW9U3PWAC&pg=PA72&lpg=PA72&dq=Incremental+Widrow-Hoff+algorithm&source=bl&ots=mWiuufoila&sig=danaX99O5RNVRrEkbw8ua6Vj7Ng&hl=en&sa=X&ei=lQpgVJ-0KbCO7Aaw_4HIDg&ved=0CCsQ6AEwAQ#v=onepage&q=Incremental%20Widrow-Hoff%20algorithm&f=false
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------



global NET_ITERMAX

% target value, Q_new, see nqlearn
target=q;

% neuron's internal learning iterations
for iter=1:NET_ITERMAX
    
    % one iteration of training
    
    % old value
    output=value_finder(state,action,vector);
    
    % learning rate
    mu=log(iter+1)/(iter+1);
    
    % updateing the vector 
    vector(action,1)=vector(action,1)+(mu*(target-output)*1);
    
    vector(action,2)=vector(action,2)+(mu*(target-output)*state);
    
end

